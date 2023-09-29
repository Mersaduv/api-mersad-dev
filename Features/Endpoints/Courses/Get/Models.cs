using mersad_dev.Entities.Courses;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public class Request
{
    public Guid Id { get; init; }

}
public class Response
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Avatar { get; set; }
    public bool IsDeleted { get; set; }
    public long Tuition { get; set; }
    public string Instructor { get; set; }
    public string Descriptions { get; set; }
    public string Keyword { get; set; }
    public int CategoryId { get; set; }
    public string Category { get; set; }
    public int Episode { get; set; }
    public bool IsComplete { get; set; }
    public string? ThumbnailUrl { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? LastUpdated { get; set; }
}

public class GetAllResponse
{
    public IEnumerable<Response> Courses { get; set; } = Enumerable.Empty<Response>();
}

public class MediaRequest
{
    public string entity { get; set; }
    public string fileName { get; set; }
}