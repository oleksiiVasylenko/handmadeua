using System.Threading.Tasks;
using Handmadeua.Core.Repositories;

namespace Handmadeua.Core
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}
