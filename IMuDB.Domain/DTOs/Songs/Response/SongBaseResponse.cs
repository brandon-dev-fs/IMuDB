namespace IMuDB.Domain.DTOs.Songs.Response
{
    public class SongBaseResponse : BaseResponseDto
    {
        public string Name { get; init; } = string.Empty;
        public int Track { get; init; }
        public int Length { get; init; }
    }
}
