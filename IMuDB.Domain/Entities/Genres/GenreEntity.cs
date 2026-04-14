using IMuDB.Domain.Entities.Songs;

namespace IMuDB.Domain.Entities.Genres
{
    public class GenreEntity : BaseEntity
    {
        // Genre Attributes
        public string Genre { get; set; } = string.Empty;
        // relationship :-: Songs
        public ICollection<SongEntity>? Songs { get; set; }
    }
}
