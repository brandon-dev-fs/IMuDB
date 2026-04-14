namespace IMuDB.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(string Id);
        Task<TEntity> AddEntityAsync(TEntity entity);
        Task<TEntity> UpdateEntityAsync(TEntity entity);
        Task DeleteByIdAsync(TEntity entity);
    }
}
