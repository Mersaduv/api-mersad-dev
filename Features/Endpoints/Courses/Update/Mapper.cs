using mersad_dev.Entities.Courses;

namespace mersad_dev.Features.Endpoints.Courses.Update;

public static class UpdateCourseMapper
{
    public static Course ToCourses(this Request request)
    {
        return new Course
        {
            Id = request.Id,
            Title = request.Title,
            Tuition = request.Tuition,
            Avatar = request.Avatar,
            IsDeleted = request.IsDeleted,
            Category = request.Category,
            CategoryId = request.CategoryId,
            Instructor = request.Instructor,
            Descriptions = request.Descriptions,
            Keyword = request.Keyword,
            Episode = request.Episode,
            IsComplete = request.IsComplete,
            LastUpdated = DateTime.Now
        };
    }

    public static Response ToResponse(this Course courses)
    {
        return new Response
        {
            Id = courses.Id,
            Title = courses.Title,
            Tuition = courses.Tuition,
            Avatar = courses.Avatar,
            IsDeleted = courses.IsDeleted,
            Category = courses.Category,
            CategoryId = courses.CategoryId,
            Instructor = courses.Instructor,
            Descriptions = courses.Descriptions,
            Keyword = courses.Keyword,
            Episode = courses.Episode,
            IsComplete = courses.IsComplete,
            LastUpdated = courses.LastUpdated
        };
    }
}