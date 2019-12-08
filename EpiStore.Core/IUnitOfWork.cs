using System;
using System.Threading.Tasks;
using EpiStore.Core.Repositories;

namespace EpiStore.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICartRepository Carts { get; }

        ICartItemRepository CartItems { get; }
        
        Task<int> CommitAsync();
    }
}