using IMuDB.Domain.DTOs.Return;

namespace IMuDB.Domain.DTOs.Return.Songs
{
    public class SongBase : BaseReturnDto
    {
        public int Length { get; init; }
        public int Track { get; init; }
    }
}
