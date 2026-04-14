using IMuDB.Domain.DTOs.Songs.Response;

namespace IMuDB.Domain.DTOs.Album.Response
{
    public class AlbumDetailsResponse : AlbumBaseResponse
    {
        public IEnumerable<SongBaseResponse> Songs { get; init; } = null!;
    }
}
