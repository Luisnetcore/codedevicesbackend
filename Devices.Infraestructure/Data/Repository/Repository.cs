
using Microsoft.EntityFrameworkCore;

namespace Devices.Infraestructure.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DeviceDBContext _context;

        public Repository(DeviceDBContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            var entityUpdated = _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entityUpdated.Entity;
        }
    }
}
