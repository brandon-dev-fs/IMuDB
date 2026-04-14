using IMuDB.Domain.DTOs.Songs.Response;

namespace IMuDB.Domain.Interfaces.Services.Song
{
    public interface ISongService
    {
        Task<SongDetailsResponse?> GetSongById(string songId);
    }
}
