using static mersad_dev.Features.Endpoints.Courses.Get.Data;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public class GetAllEndpoint : EndpointWithoutRequest<GetAllResponse>
{
    private readonly IGetRepository _repository;

    public GetAllEndpoint(IGetRepository repository)
    {
        _repository = repository;
    }

    public override void Configure()
    {
        Get("courses");
        AllowAnonymous();
        Version(1);
    }
    
    public override async Task HandleAsync(CancellationToken ct)
    {
        var courses = await _repository.GetAllAsync();
        var responseCourses = courses.ToCoursesResponse();
        await SendOkAsync(responseCourses, ct);
    }
}