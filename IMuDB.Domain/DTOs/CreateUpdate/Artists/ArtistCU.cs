using IMuDB.Domain.Entities.Artists;

namespace IMuDB.Domain.DTOs.CreateUpdate.Artists
{
    public class ArtistCU
    {
        public string Name { get; init; }
        public IList<string>? Musicians { get; init; }
        public ArtistType Type { get; init; }
    }
}
