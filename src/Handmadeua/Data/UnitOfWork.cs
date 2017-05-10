using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Handmadeua.Core;
using Handmadeua.Core.Repositories;
using Handmadeua.Data.Repositories;
using Microsoft.AspNetCore.Hosting;

namespace Handmadeua.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HandmadeContext _context;
        private readonly IHostingEnvironment _env;
        public UnitOfWork(HandmadeContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            Users = new UserRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
        }

        public IUserRepository Users { get; }
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public async Task<int> CompleteAsync()
        {
            if (!_env.IsDevelopment()) return await _context.SaveChangesAsync();

            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Debugger.Break();
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
