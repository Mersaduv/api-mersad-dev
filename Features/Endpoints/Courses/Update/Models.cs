namespace mersad_dev.Features.Endpoints.Courses.Update;

public class Request
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsOnline { get; set; }
    public double Tuition { get; set; }
    public string Instructor { get; set; }
    public int CategoryId { get; set; }
    public string Category { get; set; }
    public DateTime? Created { get; set; }

}
public class Response
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsOnline { get; set; }
    public double Tuition { get; set; }
    public string Instructor { get; set; }
    public int CategoryId { get; set; }
    public string Category { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? LastUpdated { get; set; }

}