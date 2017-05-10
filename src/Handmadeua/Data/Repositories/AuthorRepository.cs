using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Handmadeua.Data.Repositories
{
    public class AuthorRepository: Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
