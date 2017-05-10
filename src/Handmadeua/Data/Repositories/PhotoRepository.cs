using Handmadeua.Core.Repositories;
using Handmadeua.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Handmadeua.Data.Repositories
{
    public class PhotoRepository: Repository<Photo>, IPhotoRepository
    {
        public PhotoRepository(DbContext context) : base(context)
        {
        }

        public HandmadeContext DrinksContext => Context as HandmadeContext;
    }
}
