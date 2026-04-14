using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Interfaces.Repositories.Albums;
using Microsoft.EntityFrameworkCore;

namespace IMuDB.Infrastructure.Repositories.Albums
{
    public class AlbumRepository(DataContext context) : GenericRepository<AlbumEntity>(context), IAlbumRepository
    {
        public async Task<IEnumerable<AlbumEntity>?> GetAllAlbumsAsync()
        {
            return await _context.Albums
                .Where(al => al.IsActive)
                .Include(al => al.Act)
                .Include(al => al.Songs
                .OrderBy(s => s.Track))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<AlbumEntity>?> GetAllByMusicianAsync(string actId)
        {
            return await _context.Albums
                .Where(al => al.Act.Id == actId)
                .Where(al => al.IsActive)
                .Include(al => al.Act)
                .Include(al => al.Songs.OrderBy(s => s.Track)).AsNoTracking().ToListAsync();
        }

        public async Task<AlbumEntity?> GetAlbumByIdAsync(string Id)
        {
            return await _context.Albums
                .Where(al => al.Id == Id)
                .Where(al => al.IsActive)
                .Include(al => al.Act)
                .Include(al => al.Songs.OrderBy(s => s.Track))
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<AlbumEntity?> UniqueAlbumCheckAsync(string name, string actId)
        {
            return await _context.Albums
                .Where(al => al.Act.Id == actId && al.Name == name && al.IsActive)
                .Include(al => al.Songs.OrderBy(s => s.Track))
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}
