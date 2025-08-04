using System.ComponentModel.DataAnnotations.Schema;
using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Artists;

namespace IMuDB.Domain.Entities.Songs
{
    public class SongEntity : BaseEntity
    {
        public int Length { get; set; }
        public int Track { get; set; }
        public string Genre { get; set; } = string.Empty;
        public string Lyrics { get; set; } = string.Empty;
        [ForeignKey("AlbumId")]
        public AlbumEntity Album { get; init; }
        public Guid? AlbumId { get; init; }
        [ForeignKey("ArtistId")]
        public ArtistEntity Artist { get; init; }
        public Guid? ArtistId { get; init; }
    }
}