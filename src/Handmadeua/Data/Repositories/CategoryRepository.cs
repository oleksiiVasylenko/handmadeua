using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Handmadeua.Data.Repositories
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
