using mersad_dev.Entities.Courses;
using mersad_dev.Utility;

namespace mersad_dev.Features.Endpoints.Courses.Create;

public static class CreateCourseMapper
{
    public static Course ToCourses(this Request request)
    {
        return new Course
        {
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
            Created = DateTime.UtcNow,
            LastUpdated = DateTime.UtcNow
        };
    }
    public static Response ToResponse(this Course course)
    {
        return new Response
        {
            Id = course.Id,
            Title = course.Title,
            Avatar = course.Avatar,
            Tuition = course.Tuition,
            IsDeleted = course.IsDeleted,
            Category = course.Category,
            CategoryId = course.CategoryId,
            Instructor = course.Instructor,
            Descriptions = course.Descriptions,
            Keyword = course.Keyword,
            Episode = course.Episode,
            IsComplete = course.IsComplete,
            Created = course.Created,
            LastUpdated = course.LastUpdated
        };
    }
}