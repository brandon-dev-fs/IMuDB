using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Musicians.Request
{
    public class MusicianCreateRequest
    {
        [Required]
        public string Name { get; init; } = string.Empty;
        public IEnumerable<string>? InstrumentsId { get; init; }
    }
}
