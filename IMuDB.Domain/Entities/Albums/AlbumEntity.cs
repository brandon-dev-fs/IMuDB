using System.ComponentModel.DataAnnotations.Schema;
using IMuDB.Domain.Entities.Artists;
using IMuDB.Domain.Entities.Songs;

namespace IMuDB.Domain.Entities.Albums
{
    public class AlbumEntity : BaseEntity
    {
        public int Year { get; set; }
        public IList<SongEntity> Songs { get; set; }
        [ForeignKey("ArtistId")]
        public ArtistEntity Artist { get; init; }
        public Guid? ArtistId { get; init; }
    }
}
