using IMuDB.Domain.DTOs.Musicians.Request;
using IMuDB.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Act.Request
{
    public class ActCreateRequest
    {
        [Required]
        public string Name { get; init; } = string.Empty;
        [Required]
        public ActType Type { get; init; }
        public string ImageUrl { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public IEnumerable<MusicianCreateRequest>? CreateMusicians { get; init; }
        public IEnumerable<MusicianUpdateRequest>? UpdateMusicians { get; init; }
    }
}