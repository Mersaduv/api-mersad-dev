using mersad_dev.Data;
using mersad_dev.Entities;

namespace mersad_dev.Features.Endpoints.Courses.Create;

public static class Data
{

    public interface ICreateRepository
    {
        Task<bool> CreateAsync(Course course);

    }
    public class CreateRepository : ICreateRepository
    {
        private readonly ApiDbContext _db;
        public CreateRepository(ApiDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CreateAsync(Course events)
        {
            _db.Add(events);
            await _db.SaveChangesAsync();
            return true;

        }
    }

}