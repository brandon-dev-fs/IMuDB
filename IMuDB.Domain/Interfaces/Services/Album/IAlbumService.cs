using IMuDB.Domain.DTOs.CreateUpdate.Albums;
using IMuDB.Domain.DTOs.Return.Album;

namespace IMuDB.Domain.Interfaces.Services.Album
{
    public interface IAlbumService
    {
        Task<IList<AlbumBase>?> GetAllAlbumsAsync();
        Task<IList<AlbumBase>?> GetAllAlbumsByArtistAsync(Guid artistId);
        Task<AlbumDetails> GetAlbumByIdAsync(Guid Id);
        // Start Here
        Task<Guid> CreateAlbumAsync(AlbumCU album);
        Task UpdateAlbumAsync(Guid Id, AlbumCU data);

        Task DeleteAlbumAsync(Guid Id);
    }
}
