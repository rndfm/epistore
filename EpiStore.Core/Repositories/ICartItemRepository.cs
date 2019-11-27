namespace EpiStore.Core.Repositories
{
    public interface ICartItemRepository : IRepository<CartItem>
    {
        Task<ICollection<CartItem>> GetCartById(int id);

        Task<CartItem> GetWithCartById(int id);
    }
}