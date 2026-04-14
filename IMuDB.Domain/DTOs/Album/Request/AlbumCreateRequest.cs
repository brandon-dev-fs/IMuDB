using IMuDB.Domain.DTOs.Songs.Request;
using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Album.Request
{
    public class AlbumCreateRequest
    {
        [Required]
        public string Name { get; init; } = string.Empty;
        [Required]
        public int Year { get; init; }
        [Required]
        public string ActId { get; init; } = null!;
        public string ImageUrl { get; init; } = string.Empty;
        public IEnumerable<SongCreateRequest>? CreateSong { get; init; }
        public IEnumerable<SongUpdateRequest>? UpdateSong { get; init; }

    }
}