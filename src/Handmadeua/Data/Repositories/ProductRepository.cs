using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;

namespace Handmadeua.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(HandmadeContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
