using System.Threading.Tasks;
using Handmadeua.Core.UIModels;
using Handmadeua.Data.Models;

namespace Handmadeua.Core.Services
{
    public interface IUserService
    {
        Task<User> Register(UserRegistration model);
    }
}
