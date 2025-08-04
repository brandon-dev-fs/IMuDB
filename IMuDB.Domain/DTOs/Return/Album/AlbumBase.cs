using IMuDB.Domain.DTOs.Return.Artists;

namespace IMuDB.Domain.DTOs.Return.Album
{
    public class AlbumBase : BaseReturnDto
    {
        public int Year { get; init; }
        public ArtistBase Artist { get; init; }
    }
}
