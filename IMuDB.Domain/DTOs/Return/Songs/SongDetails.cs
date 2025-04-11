using IMuDB.Domain.DTOs.Return.Album;

namespace IMuDB.Domain.DTOs.Return.Songs
{
    public class SongDetails : SongBase
    {
        public string Genre { get; init; }
        public string Lyrics { get; init; }
        public AlbumBase Album { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}
