using Project.Abstractions.Models;

namespace Project.Abstractions.Services
{
    public interface ISaleService
    {
        void AddNewProduct(IProduct product);
        IProduct[] GetProducts();
        void AddNewSalesRepresentative(ISaleRepresentative salesRep);
        ISaleRepresentative[] GetSalesRepresentative();
        void CrateNewSale(ISale sale);
    }
}
