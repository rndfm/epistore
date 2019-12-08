using System.Collections.Generic;
using System.Threading.Tasks;
using EpiStore.Core.Entities;
using EpiStore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EpiStore.Data.Repositories
{
     public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(EpiStoreDbContext context) 
            : base(context)
        { }

        public async Task<CartItem> GetWithCartById(int id)
        {
            return await EpiStoreDbContext.CartItems
                .Include(i => i.Cart)
                .SingleOrDefaultAsync(i => i.Id == id);;
        }

        public async Task<ICollection<CartItem>> GetByCartId(int id)
        {
            return await EpiStoreDbContext.CartItems
                .ToListAsync();
        }

        private EpiStoreDbContext EpiStoreDbContext
        {
            get { return Context as EpiStoreDbContext; }
        }
    }
}