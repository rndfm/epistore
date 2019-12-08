using System.Threading.Tasks;
using EpiStore.Core.Entities;

namespace EpiStore.Core.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        Task<Cart> GetCartById(int id);

        Task<Cart> GetCartWithItemsById(int id);
    }
}