using IMuDB.Domain.Entities.Songs;
using IMuDB.Domain.Interfaces.Repositories.Songs;
using Microsoft.EntityFrameworkCore;

namespace IMuDB.Infrastructure.Repositories.Songs
{
    public class SongRepository(DataContext context) : GenericRepository<SongEntity>(context), ISongRepository
    {
        public async Task<SongEntity?> GetSongsByIdAsync(string Id)
        {
            return await _context.Songs
                .Where(s => s.IsActive)
                .Where(s => s.Id == Id)
                .Include(s => s.Album)
                .Include(s => s.Act)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<IList<SongEntity>?> GetSongsByAlbumAsync(string albumId)
        {
            return await _context.Songs
                .Where(s => s.IsActive)
                .Where(s => s.Album.Id == albumId)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
