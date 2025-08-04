using IMuDB.Domain.DTOs.Return.Artists;
using IMuDB.Domain.Entities.Artists;

namespace IMuDB.Infrastructure.Extensions
{
    public static class ArtistEntityExtensions
    {
        public static ArtistDetails ToDetailedDto(this ArtistEntity artist)
        {
            return new ArtistDetails
            {
                Id = artist.Id,
                Name = artist.Name,
                Musicians = artist.Musicians,
                Type = artist.Type,
                Albums = artist.Albums.Select(_ => _.ToBaseDto()).ToList(),
                UpdatedAt = artist.UpdatedAt
            };
        }

        public static ArtistBase ToBaseDto(this ArtistEntity artist)
        {
            return new ArtistBase
            {
                Id = artist.Id,
                Name = artist.Name,
                Type = artist.Type,
                Musicians = artist.Musicians
            };
        }
    }
}
