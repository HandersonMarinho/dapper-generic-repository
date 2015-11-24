using Project.Abstractions.Models;
using Project.Abstractions.Repositories;
using System;

namespace Project.Repositories
{
    public class SalesRepresentativeRepository : DapperRepository<SaleRepresentative>, ISalesRepresentativeRepository
    {
        public SalesRepresentativeRepository(IDatabaseConfig config) :
            base(config)
        {
        }

        public void Add(ISaleRepresentative salesRep)
        {
            base.Create((SaleRepresentative)salesRep);
        }

        public ISaleRepresentative[] GetAll()
        {
            return base.RetrieveAll();
        }

        public ISaleRepresentative GetById(int salesRepId)
        {
            return base.RetrieveSingle(sr => sr.Id, salesRepId);
        }
    }
}
