using mersad_dev.Data;

namespace mersad_dev.Features.Endpoints.Courses.Delete;

public class Data
{
    public interface IDeleteRepository
    {
        Task<bool> DeleteAsync(Guid id);
    }

    public class DeleteRepository : IDeleteRepository
    {
        private readonly ApiDbContext _db;

        public DeleteRepository(ApiDbContext db)
        {
            _db = db;
        }


        public async Task<bool> DeleteAsync(Guid id)
        {
            var courseItem = await _db.Courses.FindAsync(id);
            if (courseItem == null)
            {
                return false;
            }
            _db.Courses.Remove(courseItem);
            await _db.SaveChangesAsync();
            return true;
        }

    }
}