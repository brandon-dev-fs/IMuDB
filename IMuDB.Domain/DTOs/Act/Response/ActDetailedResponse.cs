using IMuDB.Domain.DTOs.Album.Response;
using IMuDB.Domain.DTOs.Musicians.Response;

namespace IMuDB.Domain.DTOs.Act.Response
{
    public class ActDetailedResponse : ActBaseResponse
    {
        public string Description { get; init; } = string.Empty;
        public IEnumerable<AlbumBaseResponse>? Albums { get; init; }
        public IEnumerable<MusicianBaseResponse> Musicians { get; init; } = null!;
    }
}
