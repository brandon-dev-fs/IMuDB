using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Songs;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMuDB.Domain.Entities.Albums
{
    public class AlbumEntity : BaseEntity
    {
        // Album Attributes
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        // relationship 1-: Songs
        public ICollection<SongEntity> Songs { get; set; } = null!;
        // relationship 1-1 Act
        [ForeignKey("ActId")]
        public ActEntity Act { get; set; } = null!;
        public string? ActId { get; set; }

    }
}
