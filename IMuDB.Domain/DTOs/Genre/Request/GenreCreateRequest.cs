using System.ComponentModel.DataAnnotations;

namespace IMuDB.Domain.DTOs.Genre.Request
{
    public class GenreCreateRequest
    {
        [Required]
        public string Genre { get; init; } = string.Empty;
    }
}
