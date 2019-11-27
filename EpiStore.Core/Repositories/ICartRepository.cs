namespace EpiStore.Core.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        Task<Cart> GetCartById(int id);
    }
}