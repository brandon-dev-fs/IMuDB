using IMuDB.Domain.Entities.Genres;
using IMuDB.Domain.Interfaces.Repositories.Genres;

namespace IMuDB.Infrastructure.Repositories.Genres
{
    public class GenreRepository(DataContext context) : GenericRepository<GenreEntity>(context), IGenreRepository
    {
    }
}
