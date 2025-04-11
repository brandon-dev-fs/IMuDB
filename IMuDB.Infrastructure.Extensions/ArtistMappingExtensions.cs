using IMuDB.Domain.DTOs.Return.Artists;
using IMuDB.Domain.Entities.Artists;
using IMuDB.Infrastructure.Extensions;
using IMuDB.Infrastructure.Extensions;

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
