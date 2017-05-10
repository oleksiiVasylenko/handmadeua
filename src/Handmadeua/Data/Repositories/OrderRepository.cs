using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;

namespace Handmadeua.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(HandmadeContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
