using IMuDB.Domain.DTOs.Musicians.Response;
using IMuDB.Domain.Entities.Musicians;
using IMuDB.Domain.Interfaces.Repositories.Musician;
using IMuDB.Domain.Interfaces.Services.Musician;
using IMuDB.Infrastructure.Extensions.Mapping.Musician;

namespace IMuDB.Infrastructure.Services.Musician
{
    public class MusicianServices(IMusicianRepository musicianRepository) : IMusicianService
    {

        /// <summary>
        /// Gets all Musicians
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MusicianBaseResponse>> GetMusiciansAsync()
        {
            IEnumerable<MusicianEntity> musicians = await musicianRepository.GetAllAsync();
            return musicians.Select(_ => _.ToBaseDto()) ?? [];
        }

        /// <summary>
        /// Gets an Musician entity by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <exception cref="Exception"></exception>
        public async Task<MusicianDetailsResponse?> GetMusicianByIdAsync(string Id)
        {
            MusicianEntity? musician = await musicianRepository.GetMusicianByIdAsync(Id);
            return musician?.ToDetailedDto();
        }

        /// <summary>
        /// Soft deletes an musician
        /// </summary>
        /// <param name="Id"></param>
        /// <exception cref="Exception"></exception>
        public async Task DeleteMusicianAsync(string Id)
        {
            MusicianEntity deletedMusician = await musicianRepository.GetByIdAsync(Id) ?? throw new Exception($"Musician with Id:{Id} could not be found.");

            deletedMusician.IsActive = false;
            deletedMusician.UpdatedAt = DateTime.UtcNow;

            await musicianRepository.UpdateEntityAsync(deletedMusician);
        }
    }
}
