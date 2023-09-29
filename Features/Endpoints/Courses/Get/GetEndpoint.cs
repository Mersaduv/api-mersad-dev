
using mersad_dev.Entities.Courses;
using mersad_dev.Utility;
using static mersad_dev.Features.Endpoints.Courses.Get.Data;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public class GetEndpoint : Endpoint<Request, Response>
{
    private readonly IGetRepository _repository;
    private readonly ByteFileUtility _byteFileUtility;

    public GetEndpoint(IGetRepository repository, ByteFileUtility byteFileUtility)
    {
        _byteFileUtility = byteFileUtility;
        _repository = repository;
    }

    public override void Configure()
    {
        Get("courses/{id:guid}");
        AllowAnonymous();
        Version(1);
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var courses = await _repository.GetAsync(req.Id);

        if (courses is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        var coursesResponse = courses.ToCourseResponse();
        coursesResponse.ThumbnailUrl = _byteFileUtility.GetEncryptedFileActionUrl(courses.ThumbnailFileName, nameof(Course));
        await SendOkAsync(coursesResponse, ct);
    }

}