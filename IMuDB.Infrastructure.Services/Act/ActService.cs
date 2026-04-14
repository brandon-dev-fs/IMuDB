using IMuDB.Domain.DTOs.Act.Request;
using IMuDB.Domain.DTOs.Act.Response;
using IMuDB.Domain.DTOs.Musicians.Request;
using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Musicians;
using IMuDB.Domain.Interfaces.Repositories.Act;
using IMuDB.Domain.Interfaces.Repositories.Musician;
using IMuDB.Domain.Interfaces.Services.Act;
using IMuDB.Infrastructure.Extensions.Mapping.Act;

namespace IMuDB.Infrastructure.Services.Act
{
    public class ActService(IActRepository actRepository, IMusicianRepository musicianRepository) : IActService
    {
        /// <summary>
        /// Gets all Acts and cast each to a base response dto
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<IEnumerable<ActBaseResponse>> GetActsAsync()
        {
            IEnumerable<ActEntity>? acts = await actRepository.GetAllActsAsync();
            return acts?.Select(_ => _.ToBaseResponseDto()) ?? [];
        }

        /// <summary>
        /// Gets an Act by Id and cast to a detailed response dto
        /// </summary>
        /// <param name="actId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<ActDetailedResponse?> GetActByIdAsync(string actId)
        {
            ActEntity? act = await actRepository.GetActByIdAsync(actId);

            return act?.ToDetailedResponseDto();
        }

        /// <summary>
        /// Creates a new act and creates musicians with or adds musicians
        /// </summary>
        /// <param name="createActRequest"></param>
        /// <returns></returns>
        public async Task<ActDetailedResponse> CreateActAsync(ActCreateRequest createActRequest)
        {
            List<MusicianEntity> musicians = [];

            if (createActRequest.UpdateMusicians != null && createActRequest.UpdateMusicians.Any())
            {
                foreach (MusicianUpdateRequest musician in createActRequest.UpdateMusicians)
                {
                    MusicianEntity musicianEntity = await musicianRepository.GetByIdAsync(musician.Id) ?? throw new Exception($"Musician with id: ${musician?.Id}");
                    musicians.Add(musicianEntity);
                }
            }

            if (createActRequest.CreateMusicians != null && createActRequest.CreateMusicians.Any())
            {
                foreach (MusicianCreateRequest musician in createActRequest.CreateMusicians)
                {
                    musicians.Add(new MusicianEntity
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = musician!.Name,
                        IsActive = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    });
                }
            }

            ActEntity createAct = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = createActRequest.Name,
                Type = createActRequest.Type,
                ImageUrl = createActRequest.ImageUrl,
                Musicians = musicians,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            return (await actRepository.AddEntityAsync(createAct)).ToDetailedResponseDto();
        }

        /// <summary>
        /// Updates acts and musicians
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="updateRequest"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task UpdateActAsync(string Id, ActUpdateRequest updateActRequest)
        {
            ActEntity updateAct = await actRepository.GetByIdAsync(Id) ?? throw new Exception($"Album with Id:{Id} could not be found");

            updateAct.ImageUrl = updateActRequest.ImageUrl;
            updateAct.Description = updateActRequest.Description;

            List<MusicianEntity> musicians = [];

            if (updateActRequest.UpdateMusicians != null && updateActRequest.UpdateMusicians.Any())
            {
                foreach (MusicianUpdateRequest musician in updateActRequest.UpdateMusicians)
                {
                    MusicianEntity musicianEntity = await musicianRepository.GetByIdAsync(musician.Id) ?? throw new Exception($"Musician with id: ${musician?.Id}");
                    musicians.Add(musicianEntity);
                }
            }

            if (updateActRequest.CreateMusicians != null && updateActRequest.CreateMusicians.Any())
            {
                foreach (MusicianCreateRequest musician in updateActRequest.CreateMusicians)
                {
                    musicians.Add(new MusicianEntity
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = musician!.Name,
                        IsActive = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    });
                }
            }

            updateAct.UpdatedAt = DateTime.UtcNow;

            await actRepository.UpdateEntityAsync(updateAct);
        }

        /// <summary>
        /// Soft delete and act by Id 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task DeleteActAsync(string actId)
        {
            ActEntity deleteAct = await actRepository.GetByIdAsync(actId) ?? throw new Exception($"Album with Id:{actId} could not be found");

            deleteAct.IsActive = false;
            deleteAct.UpdatedAt = DateTime.UtcNow;

            await actRepository.UpdateEntityAsync(deleteAct);
        }
    }
}
