using static mersad_dev.Features.Endpoints.Courses.Delete.Data;

namespace mersad_dev.Features.Endpoints.Courses.Delete;

public class Endpoints : Endpoint<Request>
{
    private readonly IDeleteRepository _repository;

    public Endpoints(IDeleteRepository deleteRepository)
    {
        _repository = deleteRepository;
    }

    public override void Configure()
    {
        Delete("courses/{id:guid}");
        AllowAnonymous();
        Version(1);
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var deleted = await _repository.DeleteAsync(req.Id);
        if (!deleted)
        {
            await SendNotFoundAsync(ct);
        }

        await SendNoContentAsync(ct);
    }

}