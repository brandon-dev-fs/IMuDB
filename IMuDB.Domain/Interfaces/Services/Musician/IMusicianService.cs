using IMuDB.Domain.DTOs.Musicians.Response;

namespace IMuDB.Domain.Interfaces.Services.Musician
{
    public interface IMusicianService
    {
        Task<IEnumerable<MusicianBaseResponse>> GetMusiciansAsync();
        Task<MusicianDetailsResponse?> GetMusicianByIdAsync(string musicianId);
        Task DeleteMusicianAsync(string genreId);
    }
}
