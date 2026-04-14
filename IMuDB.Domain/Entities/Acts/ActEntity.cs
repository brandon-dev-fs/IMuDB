using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Musicians;
using IMuDB.Domain.Entities.Songs;
using IMuDB.Domain.Enums;

namespace IMuDB.Domain.Entities.Acts
{
    public class ActEntity : BaseEntity
    {
        // Act attributes
        public string Name { get; set; } = string.Empty;
        public ActType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        // relationship 1-: Musicians
        public ICollection<MusicianEntity> Musicians { get; set; } = null!;
        // relationship 1-: Songs
        public ICollection<SongEntity>? Songs { get; set; }
        // relationship 1-: Albums
        public ICollection<AlbumEntity>? Albums { get; set; }
    }
}
