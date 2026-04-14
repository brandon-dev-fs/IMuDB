using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Genres;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMuDB.Domain.Entities.Songs
{
    public class SongEntity : BaseEntity
    {
        // Song Attributes
        public string Name { get; set; } = string.Empty;
        public int Length { get; set; }
        public int Track { get; set; }
        public string Lyrics { get; set; } = string.Empty;
        // Genre 1-1 relationship
        public GenreEntity? Genre { get; set; }
        // Album 1-1 relationship
        [ForeignKey("AlbumId")]
        public AlbumEntity Album { get; set; } = null!;
        public string? AlbumId { get; set; }
        // Act 1-1 relationship
        [ForeignKey("ActId")]
        public ActEntity Act { get; set; } = null!;
        public string? ActId { get; set; }
    }
}