using Project.Abstractions.Models;

namespace Project.Abstractions.Repositories
{
    public interface ISalesRepresentativeRepository
    {
        void Add(ISaleRepresentative salesRep);
        ISaleRepresentative GetById(int salesRepId);
        ISaleRepresentative[] GetAll();
    }
}
