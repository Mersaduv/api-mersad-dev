using mersad_dev.Data;
using mersad_dev.Entities.Courses;
using Microsoft.EntityFrameworkCore;

namespace mersad_dev.Features.Endpoints.Courses.Update;

public class Data
{
    public interface IUpdateRepository
    {
        Task UpdateAsync(Course course);
    }
    public class UpdateRepository : IUpdateRepository
    {
        private readonly ApiDbContext _db;
        public UpdateRepository(ApiDbContext db)
        {
            _db = db;
        }

        public async Task UpdateAsync(Course course)
        {
            var existingCourse = await _db.Courses.FirstOrDefaultAsync(u => u.Id == course.Id);
            if (existingCourse == null)
                return;
            existingCourse.Title = course.Title;
            existingCourse.IsDeleted = course.IsDeleted;
            existingCourse.Category = course.Category;
            existingCourse.CategoryId = course.CategoryId;
            existingCourse.Descriptions = course.Descriptions;
            existingCourse.Episode = course.Episode;
            existingCourse.IsComplete = course.IsComplete;
            existingCourse.Instructor = course.Instructor;
            existingCourse.Created = course.Created;

            await _db.SaveChangesAsync();
        }
    }
}