using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;

namespace Handmadeua.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(HandmadeContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
