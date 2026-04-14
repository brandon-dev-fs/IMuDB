using IMuDB.Domain.DTOs.Musicians.Request;
using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Act.Request
{
    public class ActUpdateRequest
    {
        [Required]
        public string Id { get; init; } = string.Empty;
        public string ImageUrl { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public IEnumerable<MusicianCreateRequest>? CreateMusicians { get; init; }
        public IEnumerable<MusicianUpdateRequest>? UpdateMusicians { get; init; }
    }
}
