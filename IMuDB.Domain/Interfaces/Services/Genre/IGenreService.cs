using IMuDB.Domain.DTOs.Genre.Request;
using IMuDB.Domain.DTOs.Genre.Response;

namespace IMuDB.Domain.Interfaces.Services.Genre
{

    public interface IGenreService
    {
        Task<IEnumerable<GenreBaseResponse>> GetGenresAsync();
        Task<GenreBaseResponse> CreateGenreAsync(GenreCreateRequest createGenreRequest);
        Task DeleteGenreAsync(string genreId);
    }
}
