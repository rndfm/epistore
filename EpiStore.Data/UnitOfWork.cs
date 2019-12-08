using System.Threading.Tasks;
using EpiStore.Core;
using EpiStore.Core.Repositories;
using EpiStore.Data.Repositories;

namespace EpiStore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EpiStoreDbContext _context;
        private CartRepository _cartRepository;
        private CartItemRepository _cartItemRepository;

        public UnitOfWork(EpiStoreDbContext context)
        {
            this._context = context;
        }

        public ICartRepository Carts => _cartRepository = _cartRepository ?? new CartRepository(_context);

        public ICartItemRepository CartItems => _cartItemRepository = _cartItemRepository ?? new CartItemRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}