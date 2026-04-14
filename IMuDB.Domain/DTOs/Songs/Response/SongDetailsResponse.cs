using IMuDB.Domain.DTOs.Act.Response;
using IMuDB.Domain.DTOs.Album.Response;
using IMuDB.Domain.DTOs.Genre.Response;

namespace IMuDB.Domain.DTOs.Songs.Response
{
    public class SongDetailsResponse : SongBaseResponse
    {
        public string Lyrics { get; init; } = null!;
        public GenreBaseResponse? Genre { get; init; }
        public ActBaseResponse Act { get; init; } = null!;
        public AlbumBaseResponse Album { get; init; } = null!;
    }
}
