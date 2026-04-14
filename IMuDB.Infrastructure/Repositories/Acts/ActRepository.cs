using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Interfaces.Repositories.Act;
using IMuDB.Infrastructure.Extensions.Querying;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace IMuDB.Infrastructure.Repositories.Acts
{
    public class ActRepository(DataContext context) : GenericRepository<ActEntity>(context), IActRepository
    {
        public async Task<IEnumerable<ActEntity>?> GetAllActsAsync()
        {
            return await _context.Acts
                .Include(act => act.Albums)
                .Where(act => act.IsActive)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ActEntity?> GetActByIdAsync(string Id)
        {
            return await _context.Acts.Where(act => act.Id == Id)
                .Where(act => act.IsActive)
                .Include(act => act.Albums!.OrderBy(al => al.Year)).ThenInclude(album => album.Songs.OrderBy(s => s.Track))
                .Include(act => act.Musicians)
                .Include(act => act.Songs)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

    }
}
