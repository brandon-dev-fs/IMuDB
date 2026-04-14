using IMuDB.Domain.Entities.Albums;

namespace IMuDB.Domain.Interfaces.Repositories.Albums
{
    public interface IAlbumRepository : IGenericRepository<AlbumEntity>
    {
        Task<IEnumerable<AlbumEntity>?> GetAllAlbumsAsync();
        Task<IEnumerable<AlbumEntity>?> GetAllByMusicianAsync(string artistId);
        Task<AlbumEntity?> GetAlbumByIdAsync(string Id);
        Task<AlbumEntity?> UniqueAlbumCheckAsync(string name, string artistId);
    }
}
