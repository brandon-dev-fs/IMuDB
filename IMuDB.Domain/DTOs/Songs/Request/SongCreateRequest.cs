using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Songs.Request
{
    public class SongCreateRequest
    {
        [Required]
        public string Name { get; init; } = string.Empty;
        [Required]
        public int Track { get; init; }
        [Required]
        public string AlbumId { get; init; } = string.Empty;
        public int Length { get; init; }
        public string? Lyrics { get; init; }
        public string? GenreId { get; init; }
    }
}
