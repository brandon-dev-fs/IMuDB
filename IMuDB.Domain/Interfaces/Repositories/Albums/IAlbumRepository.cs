using IMuDB.Domain.Entities.Albums;

namespace IMuDB.Domain.Interfaces.Repositories.Albums
{
    public interface IAlbumRepository : IGenericRepository<AlbumEntity>
    {
        Task<IList<AlbumEntity>?> GetAllAlbumsAsync();
        Task<IList<AlbumEntity>?> GetAllByArtistAsync(Guid artistId);
        Task<AlbumEntity?> GetAlbumByIdAsync(Guid Id);
        Task<AlbumEntity?> GetAlbumByNameAndArtistAsync(string name, Guid artistId);
    }
}
