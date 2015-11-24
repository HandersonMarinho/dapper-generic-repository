using Project.Abstractions.Models;

namespace Project.Abstractions.Repositories
{
    interface ISalesRepresentativeRepository
    {
        void Add(ISaleRepresentative salesRep);
        ISaleRepresentative GetById(int salesRepId);
        ISaleRepresentative[] GetAll();
    }
}
