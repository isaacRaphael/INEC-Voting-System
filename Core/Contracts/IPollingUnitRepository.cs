using Models;

namespace Core.Contracts
{
    public interface IPollingUnitRepository<T> : IAsyncRepository<PollingUnit> , IRepository<PollingUnit>
    {

    }
}
