using IMuDB.Domain.DTOs.CreateUpdate.Songs;
using IMuDB.Domain.DTOs.Return.Artists;

namespace IMuDB.Domain.DTOs.CreateUpdate.Albums
{
    public class AlbumCU
    {
        public string Name { get; init; }
        public int Year { get; init; }
        public ArtistBase Artist { get; init; }
        public IList<SongCU> Songs { get; init; }
    }
}
