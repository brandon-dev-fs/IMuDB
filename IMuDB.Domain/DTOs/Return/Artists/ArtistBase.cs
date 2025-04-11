using IMuDB.Domain.DTOs.Return;
using IMuDB.Domain.Entities.Artists;

namespace IMuDB.Domain.DTOs.Return.Artists
{
    public class ArtistBase : BaseReturnDto
    {
        public IList<string>? Musicians { get; init; }
        public ArtistType Type { get; init; }
    }
}
