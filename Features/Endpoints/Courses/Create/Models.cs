using mersad_dev.Entities.Courses;

namespace mersad_dev.Features.Endpoints.Courses.Create;
public class Request
{
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
    public IFormFile Thumbnail { get; set; }
    public bool IsComplete { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? LastUpdated { get; set; }
}

public class Response
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Avatar { get; set; }
    public bool IsDeleted { get; set; }
    public long Tuition { get; set; }
    public string Instructor { get; set; }
    public int CategoryId { get; set; }
    public string Category { get; set; }
    public string Descriptions { get; set; }
    public string Keyword { get; set; }
    public int Episode { get; set; }
    public bool IsComplete { get; set; }
    public IFormFile Thumbnail { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? LastUpdated { get; set; }

}