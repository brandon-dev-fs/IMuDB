using IMuDB.Domain.DTOs.Genre.Response;
using IMuDB.Domain.Entities.Genres;

namespace IMuDB.Infrastructure.Extensions.Mapping.Genre
{
    public static class GenreEntityExtensions
    {
        public static GenreBaseResponse ToBaseDto(this GenreEntity genre)
        {
            return new GenreBaseResponse
            {
                Id = genre.Id,
                Genre = genre.Genre,
                UpdatedAt = genre.UpdatedAt,
            };
        }
    }
}
