using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Songs;

namespace IMuDB.Domain.Entities.Artists
{
    public class ArtistEntity : BaseEntity
    {
        public IList<string>? Musicians { get; set; }
        public IList<AlbumEntity>? Albums { get; set; }
        public IList<SongEntity>? Songs { get; set; }
        public ArtistType Type { get; set; }
    }
}
