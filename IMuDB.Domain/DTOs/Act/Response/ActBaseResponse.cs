using IMuDB.Domain.Enums;

namespace IMuDB.Domain.DTOs.Act.Response
{
    public class ActBaseResponse : BaseResponseDto
    {
        public string Name { get; init; } = string.Empty;
        public string ImageUrl { get; init; } = string.Empty;
        public ActType Type { get; init; }
    }
}
