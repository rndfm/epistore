using System.Threading.Tasks;
using EpiStore.Core.Entities;

namespace EpiStore.Core.Services
{
    public interface ICartService
    {
        Task<Cart> GetCartById(int id);

        Task<Cart> CreateCart(Cart cart);

        Task UpdateCart(Cart cartToBeUpdated, Cart cart);
        
        Task DeleteCart(Cart Cart);
    }
}