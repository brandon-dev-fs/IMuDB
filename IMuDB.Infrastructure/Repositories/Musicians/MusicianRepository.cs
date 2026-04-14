using IMuDB.Domain.Entities.Musicians;
using IMuDB.Domain.Interfaces.Repositories.Musician;
using Microsoft.EntityFrameworkCore;

namespace IMuDB.Infrastructure.Repositories.Musicians
{
    public class MusicianRepository(DataContext context) : GenericRepository<MusicianEntity>(context), IMusicianRepository
    {
        public async Task<IEnumerable<MusicianEntity>?> GetMusicianByActIdAsync(string actId)
        {
            return await _context.Acts
                .Where(a => a.IsActive)
                .Where(a => a.Id == actId)
                .Select(a => a.Musicians.Where(m => m.IsActive))
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<MusicianEntity?> GetMusicianByIdAsync(string musicianId)
        {
            return await _context.Musicians
                .Where(m => m.IsActive)
                .Where(m => m.Id == musicianId)
                .Include(m => m.Instruments)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<MusicianEntity?> FindActiveMusicianByNameAsync(string name)
        {
            return await _context.Musicians
                .Where(m => m.IsActive)
                .Where(m => m.Name == name)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

    }
}
