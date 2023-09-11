
using static mersad_dev.Features.Endpoints.Courses.Get.Data;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public class GetEndpoint : Endpoint<Request, Response>
{
    private readonly IGetRepository _repository;

    public GetEndpoint(IGetRepository repository)
    {
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
        await SendOkAsync(coursesResponse, ct);
    }

}