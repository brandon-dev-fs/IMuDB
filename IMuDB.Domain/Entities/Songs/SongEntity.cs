using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Artists;

namespace IMuDB.Domain.Entities.Songs
{
    public class SongEntity : BaseEntity
    {
        public int Length { get; set; }
        public int Track { get; set; }
        public string? Genre { get; set; }
        public string? Lyrics { get; set; }
        public AlbumEntity? Album { get; set; }
        public ArtistEntity? Artist { get; set; }
    }
}