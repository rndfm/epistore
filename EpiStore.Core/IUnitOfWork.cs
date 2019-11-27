namespace EpiStore.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICartRepository Carts { get; }
        Task<int> CommitAsync();
    }
}