using mersad_dev.Features.Endpoints.Courses.Get;
using static mersad_dev.Features.Endpoints.Courses.Create.Data;

namespace mersad_dev.Features.Endpoints.Courses.Create;

public class Endpoints : Endpoint<Request, Response>
{
    private readonly ICreateRepository _repository;

    public Endpoints(ICreateRepository repository)
    {
        _repository = repository;
    }

    public override void Configure()
    {
        Post("/api/course");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var courses = req.ToCourses();
        await _repository.CreateAsync(courses);
        var eventResponse = courses.ToResponse();
        await SendCreatedAtAsync<GetEndpoint>(new { Id = courses.Id }, eventResponse, generateAbsoluteUrl: true, cancellation: ct);

    }
}
