using mersad_dev.Entities;

namespace mersad_dev.Features.Endpoints.Courses.Create;

public static class CreateCourseMapper
{

    public static Course ToCourses(this Request request)
    {
        return new Course
        {
            Title = request.Title,
            IsOnline = request.IsOnline,
            Category = request.Category,
            CategoryId = request.CategoryId,
            Instructor = request.Instructor,
            Created = request.Created,
        };
    }
    public static Response ToResponse(this Course events)
    {
        return new Response
        {
            Id = events.Id,
            IsOnline = events.IsOnline,
            Title = events.Title,
            Category = events.Category,
            CategoryId = events.CategoryId,
            Instructor = events.Instructor,
            Created = events.Created,
            LastUpdated = events.LastUpdated
        };
    }
}