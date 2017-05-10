using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Handmadeua.Data.Repositories
{
    public class CityRepository: Repository<City>, ICityRepository
    {
        public CityRepository(DbContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
