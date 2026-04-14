
using IMuDB.Domain.DTOs.Album.Request;
using IMuDB.Domain.DTOs.Album.Response;

namespace IMuDB.Domain.Interfaces.Services.Album
{
    public interface IAlbumService
    {
        Task<IEnumerable<AlbumBaseResponse>> GetAlbumsByMusicianAsync(string actId);
        Task<IEnumerable<AlbumBaseResponse>> GetAlbumsAsync();
        Task<AlbumDetailsResponse?> GetAlbumByIdAsync(string albumId);
        Task<AlbumDetailsResponse> CreateAlbumAsync(AlbumCreateRequest createAlbumRequest);
        Task UpdateAlbumAsync(string albumId, AlbumUpdateRequest updateAlbumRequest);
        Task DeleteAlbumAsync(string albumId);
    }
}
