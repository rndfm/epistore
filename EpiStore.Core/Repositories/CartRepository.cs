namespace EpiStore.Core.Repositories
{
public class CartRepository : Repository<Cart>, ICartRepository
    {
        public ArtistRepository(EpiStoreDbContext context) 
            : base(context)
        { }

        public Task<Artist> GetCartById(int id)
        {
            return EpiStoreDbContext.Artists
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public Task<Artist> GetCartWithItemsById(int id)
        {
            return EpiStoreDbContext.Artists
                .Include(c => c.Items)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        private EpiStoreDbContext EpiStoreDbContext
        {
            get { return Context as EpiStoreDbContext; }
        }
    }
}