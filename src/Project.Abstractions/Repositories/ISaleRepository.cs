using Project.Abstractions.Models;

namespace Project.Abstractions.Repositories
{
    public interface ISaleRepository
    {
        void Add(ISale sale);
        void Cancel(ISale sale);
    }
}
