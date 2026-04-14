using IMuDB.Domain.Entities.Users;
using IMuDB.Domain.Interfaces.Repositories.Users;

namespace IMuDB.Infrastructure.Repositories.Users
{
    public class UserRepository(DataContext context) : GenericRepository<UserEntity>(context), IUserRepository
    {
    }
}
