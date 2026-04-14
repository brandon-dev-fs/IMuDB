using IMuDB.Domain.DTOs.Musicians.Response;
using IMuDB.Domain.Entities.Musicians;
using IMuDB.Infrastructure.Extensions.Mapping.Instrument;

namespace IMuDB.Infrastructure.Extensions.Mapping.Musician
{
    public static class MusicianEntityExtensions
    {
        public static MusicianDetailsResponse ToDetailedDto(this MusicianEntity musician)
        {
            return new MusicianDetailsResponse
            {
                Id = musician.Id,
                Name = musician.Name,
                Instruments = musician.Instruments?.Select(_ => _.ToBaseDto()),
                UpdatedAt = musician.UpdatedAt
            };
        }

        public static MusicianBaseResponse ToBaseDto(this MusicianEntity musician)
        {
            return new MusicianBaseResponse
            {
                Id = musician.Id,
                Name = musician.Name,
                UpdatedAt = musician.UpdatedAt
            };
        }
    }
}
