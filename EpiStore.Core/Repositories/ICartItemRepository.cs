using System.Collections.Generic;
using System.Threading.Tasks;
using EpiStore.Core.Entities;

namespace EpiStore.Core.Repositories
{
    public interface ICartItemRepository : IRepository<CartItem>
    {
        Task<ICollection<CartItem>> GetByCartId(int id);

        Task<CartItem> GetWithCartById(int id);
    }
}