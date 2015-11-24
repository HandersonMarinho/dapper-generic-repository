using Project.Abstractions.Models;

namespace Project.Abstractions.Repositories
{
    interface ISaleRepository
    {
        void Add(ISale sale);
        void Cancel(ISale sale);
    }
}
