using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Instrument.Request
{
    public class InstrumentCreateRequest
    {
        [Required]
        public string Instrument { get; init; } = string.Empty;
    }
}
