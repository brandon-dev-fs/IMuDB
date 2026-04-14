using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Songs.Request
{
    public class SongUpdateRequest
    {
        public string Id { get; init; } = string.Empty;
        [Required]
        public string Lyrics { get; init; } = string.Empty;
    }
}
