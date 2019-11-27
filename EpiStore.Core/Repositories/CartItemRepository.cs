namespace EpiStore.Core.Repositories
{
     public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(EpiStoreDbContext context) 
            : base(context)
        { }

        public async Task<IEnumerable<Music>> GetByCartId()
        {
            return await EpiStoreDbContext.Musics
                .Include(m => m.Artist)
                .ToListAsync();
        }

        public async Task<Music> GetWithCartById(int id)
        {
            return await EpiStoreDbContext.Musics
                .Include(i => i.Cart)
                .SingleOrDefaultAsync(i => i.Id == id);;
        }
        
        private EpiStoreDbContext EpiStoreDbContext
        {
            get { return Context as EpiStoreDbContext; }
        }
    }
}