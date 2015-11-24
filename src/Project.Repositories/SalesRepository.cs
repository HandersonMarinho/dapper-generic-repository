using Project.Abstractions.Models;
using Project.Abstractions.Repositories;

namespace Project.Repositories
{
    public class SalesRepository : DapperRepository<Sale>, ISaleRepository
    {
        public SalesRepository(IDatabaseConfig config) :
            base(config)
        {
        }

        public void Add(ISale sale)
        {
            base.Create((Sale)sale);
        }

        public void Cancel(ISale sale)
        {
            base.Delete((Sale)sale);
        }
    }
}
