using Models;

namespace Core.Contracts
{
    public interface ICandidateRepository<T> : IAsyncRepository<Candidate> , IRepository<Candidate>
    {

    }
}
