using IMuDB.Domain.Entities.Songs;
using IMuDB.Domain.Interfaces.Repositories;

namespace IMuDB.Domain.Interfaces.Repositories.Songs
{
    public interface ISongRepository : IGenericRepository<SongEntity>
    {
        Task<SongEntity?> GetSongDetailsByIdAsync(Guid Id);
        Task<IList<SongEntity>?> GetSongsByAlbumAsync(Guid albumId);
    }
}
