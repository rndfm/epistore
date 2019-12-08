using System.Threading.Tasks;
using EpiStore.Core.Entities;
using EpiStore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EpiStore.Data.Repositories
{
public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(EpiStoreDbContext context) 
            : base(context)
        { }

        public Task<Cart> GetCartById(int id)
        {
            return EpiStoreDbContext.Carts
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public Task<Cart> GetCartWithItemsById(int id)
        {
            return EpiStoreDbContext.Carts
                .Include(c => c.Items)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        private EpiStoreDbContext EpiStoreDbContext
        {
            get { return Context as EpiStoreDbContext; }
        }
    }
}