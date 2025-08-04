using IMuDB.Domain.Entities.Artists;

namespace IMuDB.Domain.Interfaces.Repositories.Artist
{
    public interface IArtistRepository : IGenericRepository<ArtistEntity>
    {
        Task<IList<ArtistEntity>?> GetAllArtistAsync();
        Task<ArtistEntity?> GetArtistByIdAsync(Guid Id);
        Task<ArtistEntity?> FindArtistByNameAsync(string name);
    }
}
