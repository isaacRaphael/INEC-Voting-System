using Models;

namespace Core.Contracts
{
    public interface IElectionRepository<T> : IAsyncRepository<Election> , IRepository<Election>
    {

    }
}
