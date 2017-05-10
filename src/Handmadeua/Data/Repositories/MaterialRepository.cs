using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Handmadeua.Data.Repositories
{
    public class MaterialRepository: Repository<Material>, IMaterialRepository
    {
        public MaterialRepository(DbContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
