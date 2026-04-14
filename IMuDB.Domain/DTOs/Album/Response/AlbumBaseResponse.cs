using IMuDB.Domain.DTOs.Act.Response;

namespace IMuDB.Domain.DTOs.Album.Response
{
    public class AlbumBaseResponse : BaseResponseDto
    {
        public string Name { get; init; } = string.Empty;
        public string ImageUrl { get; init; } = string.Empty;
        public ActBaseResponse Act { get; init; } = null!;
        public int Year { get; init; }
    }
}
