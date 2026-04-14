using IMuDB.Domain.Entities.Songs;

namespace IMuDB.Domain.Interfaces.Repositories.Songs
{
    public interface ISongRepository : IGenericRepository<SongEntity>
    {
        Task<SongEntity?> GetSongsByIdAsync(string Id);
        Task<IList<SongEntity>?> GetSongsByAlbumAsync(string albumId);
    }
}
