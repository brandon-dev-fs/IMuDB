using IMuDB.Domain.Entities.Musicians;

namespace IMuDB.Domain.Interfaces.Repositories.Musician
{
    public interface IMusicianRepository : IGenericRepository<MusicianEntity>
    {
        Task<IEnumerable<MusicianEntity>?> GetMusicianByActIdAsync(string actId);
        Task<MusicianEntity?> GetMusicianByIdAsync(string musicianId);
        Task<MusicianEntity?> FindActiveMusicianByNameAsync(string name);
    }
}
