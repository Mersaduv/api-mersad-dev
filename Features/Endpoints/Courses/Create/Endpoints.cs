using mersad_dev.Entities.Courses;
using mersad_dev.Features.Endpoints.Courses.Get;
using mersad_dev.Utility;
using static mersad_dev.Features.Endpoints.Courses.Create.Data;

namespace mersad_dev.Features.Endpoints.Courses.Create;

public class Endpoints : Endpoint<Request, Response>
{
    private readonly ICreateRepository _repository;
    private readonly ByteFileUtility _byteFileUtility;

    public Endpoints(ICreateRepository repository, ByteFileUtility byteFileUtility)
    {
        _repository = repository;
        _byteFileUtility = byteFileUtility;

    }

    public override void Configure()
    {
        Post("courses");
        AllowFileUploads();
        AllowAnonymous();
        Version(1);
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var courses = req.ToCourses();
        courses.ThumbnailFileName = _byteFileUtility.SaveFileInFolder(req.Thumbnail, nameof(Course), false);//!Boolean true is encrypted and Boolean false is not encrypted
        courses.Thumbnail = _byteFileUtility.EncryptFile(_byteFileUtility.ConvertToByteArray(req.Thumbnail));
        courses.ThumbnailFileExtension = _byteFileUtility.GetFileExtension(req.Thumbnail.FileName);
        courses.ThumbnailFileSize = req.Thumbnail.Length;
        await _repository.CreateAsync(courses);
        var courseResponse = courses.ToResponse();
        await SendCreatedAtAsync<GetEndpoint>(new { Id = courses.Id }, courseResponse, generateAbsoluteUrl: true, cancellation: ct);

    }
}
