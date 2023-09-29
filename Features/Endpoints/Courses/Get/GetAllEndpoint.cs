using mersad_dev.Entities.Courses;
using mersad_dev.Utility;
using static mersad_dev.Features.Endpoints.Courses.Get.Data;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public class GetAllEndpoint : EndpointWithoutRequest<GetAllResponse>
{
    private readonly IGetRepository _repository;
    private readonly ByteFileUtility _byteFileUtility;


    public GetAllEndpoint(IGetRepository repository, ByteFileUtility byteFileUtility)
    {
        _repository = repository;
        _byteFileUtility = byteFileUtility;

    }

    public override void Configure()
    {
        Version(1);
        Get("courses");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var courses = await _repository.GetAllAsync();
        // var responseCourses = courses.Select(course => new Response
        // {
        //     Id = course.Id,
        //     Title = course.Title,
        //     Tuition = course.Tuition,
        //     Avatar = course.Avatar,
        //     IsDeleted = course.IsDeleted,
        //     Category = course.Category,
        //     CategoryId = course.CategoryId,
        //     Instructor = course.Instructor,
        //     Descriptions = course.Descriptions,
        //     Keyword = course.Keyword,
        //     Episode = course.Episode,
        //     IsComplete = course.IsComplete,
        //     ThumbnailUrl = _byteFileUtility.GetEncryptedFileActionUrl(course.ThumbnailFileName, nameof(Course)),
        //     Created = course.Created,
        //     LastUpdated = course.LastUpdated
        // }).ToList();
        var responseCourses = courses.ToCoursesResponse(_byteFileUtility);
        await SendOkAsync(responseCourses, ct);
    }
}