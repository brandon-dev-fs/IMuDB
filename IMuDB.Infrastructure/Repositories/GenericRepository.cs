using IMuDB.Domain.Entities;
using IMuDB.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace IMuDB.Infrastructure.Repositories
{
    public class GenericRepository<TEntity>(DataContext context) : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DataContext _context = context;

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            // set() returns the set of a given entity type
            return await _context.Set<TEntity>().Where(e => e.IsActive).AsNoTracking().ToListAsync();
        }

        // No thrown exception for null lookups that is left to the client to decide if exception or not
        public async Task<TEntity?> GetByIdAsync(string Id)
        {
            return await _context.FindAsync<TEntity>(Id);
        }

        public async Task<TEntity> AddEntityAsync(TEntity entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateEntityAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Implementation for a hard delete. Soft deletes where is active is set to false are handled via an update
        public async Task DeleteByIdAsync(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
