using Project.Abstractions.Models;
using Project.Abstractions.Repositories;
using System;

namespace Project.Repositories
{
    public class ProductRepository : DapperRepository<Product>, IProductRepository
    {
        public ProductRepository(IDatabaseConfig config) :
            base(config)
        {
        }

        public void Add(IProduct product)
        {
            base.Create((Product)product);
        }

        public IProduct[] GetAll()
        {
            return base.RetrieveAll();
        }

        public IProduct GetById(int productId)
        {
            return base.RetrieveSingle(p => p.Id, productId);
        }
    }
}
