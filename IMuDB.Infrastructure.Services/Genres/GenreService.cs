// using IMuDB.Domain.DTOs.Genre;
using IMuDB.Domain.DTOs.Genre.Request;
using IMuDB.Domain.DTOs.Genre.Response;
using IMuDB.Domain.Entities.Genres;
using IMuDB.Domain.Interfaces.Repositories.Genres;
using IMuDB.Domain.Interfaces.Services.Genre;

// using IMuDB.Domain.Interfaces.Services.Genre;
using IMuDB.Infrastructure.Extensions.Mapping.Genre;

namespace IMuDB.Infrastructure.Services.Genres
{
    public class GenreService(IGenreRepository genreRepository) : IGenreService
    {
        public async Task<IEnumerable<GenreBaseResponse>> GetGenresAsync()
        {
            IEnumerable<GenreEntity> Genres = await genreRepository.GetAllAsync();
            return Genres.Select(_ => _.ToBaseDto()) ?? [];
        }

        public async Task<GenreBaseResponse> CreateGenreAsync(GenreCreateRequest createGenreRequest)
        {
            GenreEntity Genre = await genreRepository.AddEntityAsync(new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = createGenreRequest.Genre,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            });

            return Genre.ToBaseDto();
        }

        public async Task DeleteGenreAsync(string genreId)
        {
            GenreEntity Genre = await genreRepository.GetByIdAsync(genreId) ?? throw new Exception($"Could not find Genre with Id: {genreId}");

            Genre.IsActive = false;
            Genre.UpdatedAt = DateTime.UtcNow;

            await genreRepository.UpdateEntityAsync(Genre);
        }
    }
}
