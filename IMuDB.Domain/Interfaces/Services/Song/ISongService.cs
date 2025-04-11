using IMuDB.Domain.DTOs.CreateUpdate.Songs;
using IMuDB.Domain.DTOs.Return.Songs;

namespace IMuDB.Domain.Interfaces.Services.Song
{
    public interface ISongService
    {
        Task<IList<SongBase>?> GetAllSongsAsync();
        Task<IList<SongBase>?> GetAllSongsByAlbumAsync(Guid albumId);
        Task<SongDetails> GetSongByIdAsync(Guid Id);
        Task UpdateSongAsync(Guid Id, SongCU data);
    }
}
