using IMuDB.Domain.Entities.Songs;

namespace IMuDB.Domain.Interfaces.Repositories.Songs
{
    public interface ISongRepository : IGenericRepository<SongEntity>
    {
        Task<SongEntity?> GetSongDetailsByIdAsync(Guid Id);
        Task<IList<SongEntity>?> GetSongsByAlbumAsync(Guid albumId);
    }
}
