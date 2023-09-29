using mersad_dev.Entities.Courses;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public static class GetCourseMapper
{
    public static Response ToCourseResponse(this Course course)
    {
        return new Response
        {
            Id = course.Id,
            Title = course.Title,
            Tuition = course.Tuition,
            Avatar = course.Avatar,
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

    public static GetAllResponse ToCoursesResponse(this IEnumerable<Course> courses, Utility.ByteFileUtility _byteFileUtility)
    {
        return new GetAllResponse
        {
            Courses = courses.Select(course => new Response
            {
                Id = course.Id,
                Title = course.Title,
                Tuition = course.Tuition,
                Avatar = course.Avatar,
                IsDeleted = course.IsDeleted,
                Category = course.Category,
                CategoryId = course.CategoryId,
                Instructor = course.Instructor,
                Descriptions = course.Descriptions,
                Keyword = course.Keyword,
                Episode = course.Episode,
                IsComplete = course.IsComplete,
                ThumbnailUrl = _byteFileUtility.GetEncryptedFileActionUrl(course.ThumbnailFileName, nameof(Course)),
                Created = course.Created,
                LastUpdated = course.LastUpdated
            })
        };
    }
}