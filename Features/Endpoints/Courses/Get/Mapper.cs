using mersad_dev.Entities;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public static class EventMapper
{
    public static Response ToCourseResponse(this Course course)
    {
        return new Response
        {
            Id = course.Id,
            Title = course.Title,
            IsOnline = course.IsOnline,
            Instructor = course.Instructor,
            Tuition = course.Tuition,
            Category = course.Category,
            CategoryId = course.CategoryId,
            Created = course.Created,
            LastUpdated = course.LastUpdated
        };
    }

    public static GetAllResponse ToCoursesResponse(this IEnumerable<Course> events)
    {
        return new GetAllResponse
        {
            Courses = events.Select(eve => new Response
            {
                Id = eve.Id,
                Title = eve.Title,
                IsOnline = eve.IsOnline,
                Instructor = eve.Instructor,
                Tuition = eve.Tuition,
                Category = eve.Category,
                CategoryId = eve.CategoryId,
                Created = eve.Created,
                LastUpdated = eve.LastUpdated
            })
        };
    }
}