namespace mersad_dev.Entities.Courses;

public class Course
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
    public byte[]? Thumbnail { get; set; }
    public string? ThumbnailFileName { get; set; }
    public long ThumbnailFileSize { get; set; }
    public string? ThumbnailFileExtension { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? LastUpdated { get; set; }

}
