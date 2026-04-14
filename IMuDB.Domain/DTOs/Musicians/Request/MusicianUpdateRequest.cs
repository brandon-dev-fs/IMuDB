using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Musicians.Request
{
    public class MusicianUpdateRequest
    {
        public string Id { get; init; } = string.Empty;
        [Required]
        public IEnumerable<string> InstrumentsId { get; init; } = null!;
    }
}
