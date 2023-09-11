using mersad_dev.Data;
using mersad_dev.Entities;
using Microsoft.EntityFrameworkCore;

namespace mersad_dev.Features.Endpoints.Courses.Get;

public class Data
{
    public interface IGetRepository
    {
        Task<IEnumerable<Course>> GetAllAsync();
        Task<Course> GetAsync(Guid id);
        Task<Course> GetAsync(string eventsName);

    }
    public class GetRepository : IGetRepository
    {
        private readonly ApiDbContext _db;
        public GetRepository(ApiDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _db.Courses.ToListAsync();
        }

        public async Task<Course> GetAsync(Guid id)
        {
            return await _db.Courses.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Course> GetAsync(string eventsName)
        {
            return await _db.Courses.FirstOrDefaultAsync(u => u.Title.ToLower() == eventsName.ToLower());
        }
    }

}