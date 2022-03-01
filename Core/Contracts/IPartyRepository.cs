using Models;

namespace Core.Contracts
{
    public interface IPartyRepository<T> : IAsyncRepository<Party> , IRepository<Party>
    {

    }
}
