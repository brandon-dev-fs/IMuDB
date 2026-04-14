using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Songs;

namespace IMuDB.Domain.Entities.Users
{
    public class UserEntity : BaseEntity
    {
        // User Attributes
        public string UserName { get; set; } = string.Empty;
        // relationship 1-: Songs
        public IEnumerable<ActEntity> FavoriteActs { get; set; } = null!;
        // relationship 1-: Songs
        public IEnumerable<SongEntity> FavoriteSongs { get; set; } = null!;
        // relationship 1-: Albums
        public IEnumerable<AlbumEntity> FavoriteAlbums { get; set; } = null!;
    }
}