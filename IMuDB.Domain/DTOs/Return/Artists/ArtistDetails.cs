using IMuDB.Domain.DTOs.Return.Album;

namespace IMuDB.Domain.DTOs.Return.Artists
{
    public class ArtistDetails : ArtistBase
    {
        public IList<AlbumBase>? Albums { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}
