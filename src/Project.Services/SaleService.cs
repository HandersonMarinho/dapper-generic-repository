using Project.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Abstractions.Models;
using Project.Abstractions.Repositories;

namespace Project.Services
{
    public class SaleService : ISaleService
    {
        public SaleService(ISaleRepository saleRepo, IProductRepository productRepo, ISalesRepresentativeRepository salerepRepo)
        {
            if (saleRepo == null)
                throw new ArgumentNullException(nameof(saleRepo));

            if (productRepo == null)
                throw new ArgumentNullException(nameof(productRepo));

            if (salerepRepo == null)
                throw new ArgumentNullException(nameof(salerepRepo));

            SaleRepository = saleRepo;
            ProductRepository = productRepo;
            SalesRepRepository = salerepRepo;
        }

        private ISaleRepository SaleRepository { get; }
        private IProductRepository ProductRepository { get; }
        private ISalesRepresentativeRepository SalesRepRepository { get; }

        public void AddNewProduct(IProduct product)
        {
            ProductRepository.Add(product);
        }

        public void AddNewSalesRepresentative(ISaleRepresentative salesRep)
        {
            SalesRepRepository.Add(salesRep);
        }

        public void CrateNewSale(ISale sale)
        {
            SaleRepository.Add(sale);
        }

        public IProduct[] GetProducts()
        {
            return ProductRepository.GetAll();
        }

        public ISaleRepresentative[] GetSalesRepresentative()
        {
            return SalesRepRepository.GetAll();
        }
    }
}
