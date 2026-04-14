using IMuDB.Domain.Entities.Acts;

namespace IMuDB.Domain.Interfaces.Repositories.Act
{
    public interface IActRepository : IGenericRepository<ActEntity>
    {
        Task<IEnumerable<ActEntity>?> GetAllActsAsync();
        Task<ActEntity?> GetActByIdAsync(string Id);
    }
}
