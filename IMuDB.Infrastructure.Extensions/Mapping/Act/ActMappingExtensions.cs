using IMuDB.Domain.DTOs.Act.Response;
using IMuDB.Domain.Entities.Acts;
using IMuDB.Infrastructure.Extensions.Mapping.Album;
using IMuDB.Infrastructure.Extensions.Mapping.Musician;

namespace IMuDB.Infrastructure.Extensions.Mapping.Act
{
    public static class ActMappingExtensions
    {
        public static ActDetailedResponse ToDetailedResponseDto(this ActEntity act)
        {
            return new ActDetailedResponse
            {
                Id = act.Id,
                Name = act.Name,
                Type = act.Type,
                ImageUrl = act.ImageUrl,
                Description = act.Description,
                Albums = act.Albums?.Select(_ => _.ToBaseDto()).ToList() ?? null,
                Musicians = act!.Musicians.Select(_ => _.ToBaseDto()),
                UpdatedAt = act.UpdatedAt,
            };
        }

        public static ActBaseResponse ToBaseResponseDto(this ActEntity act)
        {
            return new ActBaseResponse
            {
                Id = act.Id,
                Name = act.Name,
                Type = act.Type,
                ImageUrl = act.ImageUrl,
                UpdatedAt = act.UpdatedAt,
            };
        }
    }
}
