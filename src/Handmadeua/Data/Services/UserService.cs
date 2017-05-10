using System;
using System.Threading.Tasks;
using Handmadeua.Core;
using Handmadeua.Core.Services;
using Handmadeua.Core.UIModels;
using Handmadeua.Data.Models;

namespace Handmadeua.Data.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<User> Register(UserRegistration model)
        {
            throw new NotImplementedException();
        }
    }
}
