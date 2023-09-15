using mersad_dev.Entities;

namespace mersad_dev.Features.Endpoints.Courses.Update;

public static class UpdateCourseMapper
{
    public static Course ToCourses(this Request request)
    {
        return new Course
        {
            Id = request.Id,
            Title = request.Title,
            IsOnline = request.IsOnline,
            Category = request.Category,
            CategoryId = request.CategoryId,
            Instructor = request.Instructor,
            Created = request.Created,

        };
    }

    public static Response ToResponse(this Course courses)
    {
        return new Response
        {
            Id = courses.Id,
            Title = courses.Title,
            IsOnline = courses.IsOnline,
            Category = courses.Category,
            CategoryId = courses.CategoryId,
            Instructor = courses.Instructor,
            Created = courses.Created,
            LastUpdated = courses.LastUpdated
        };
    }
}