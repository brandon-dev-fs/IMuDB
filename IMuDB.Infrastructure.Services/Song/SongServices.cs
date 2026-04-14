using IMuDB.Domain.DTOs.Songs.Response;
using IMuDB.Domain.Entities.Songs;
using IMuDB.Domain.Interfaces.Repositories.Songs;
using IMuDB.Domain.Interfaces.Services.Song;
using IMuDB.Infrastructure.Extensions.Mapping.Song;

namespace IMuDB.Infrastructure.Services.Song
{
    public class SongServices(ISongRepository songRepository)
        : ISongService
    {
        public async Task<SongDetailsResponse?> GetSongById(string songId)
        {
            SongEntity? song = await songRepository.GetSongsByIdAsync(songId);
            return song?.ToDetailedDto();
        }
    }
}
