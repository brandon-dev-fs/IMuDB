using IMuDB.Domain.DTOs.Return.Songs;

namespace IMuDB.Domain.DTOs.Return.Album
{
    public class AlbumDetails : AlbumBase
    {
        public IList<SongBase> Songs { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}
