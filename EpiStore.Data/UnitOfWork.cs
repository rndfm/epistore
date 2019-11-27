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

        public CartRepository Carts => _cartRepository = _cartRepository ?? new CartRepository(_context);

        public CartItemRepository CartItems => _cartItemRepository = _cartItemRepository ?? new CartItemRepository(_context);

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