using static mersad_dev.Features.Endpoints.Courses.Get.Data;
using static mersad_dev.Features.Endpoints.Courses.Update.Data;

namespace mersad_dev.Features.Endpoints.Courses.Update;

public class Endpoints : Endpoint<Request, Response>
{
    private readonly IUpdateRepository _repository;
    private readonly IGetRepository _getRepo;

    public Endpoints(IUpdateRepository repository, IGetRepository getRepo)
    {
        _repository = repository;
        _getRepo = getRepo;
    }

    public override void Configure()
    {
        Put("courses/{id:guid}");
        AllowAnonymous();
        Version(1);
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var existingCourse = await _getRepo.GetAsync(req.Id);

        if (existingCourse is null)
        {
            await SendNotFoundAsync(ct);
        }
        existingCourse.Title = req.Title;
        existingCourse.IsDeleted = req.IsDeleted;
        existingCourse.Category = req.Category;
        existingCourse.CategoryId = req.CategoryId;
        existingCourse.Descriptions = req.Descriptions;
        existingCourse.Episode = req.Episode;
        existingCourse.IsComplete = req.IsComplete;
        existingCourse.Instructor = req.Instructor;

        await _repository.UpdateAsync(existingCourse);

        var courseResponse = existingCourse.ToResponse();
        await SendOkAsync(courseResponse, ct);
    }
}