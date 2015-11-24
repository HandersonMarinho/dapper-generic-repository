using Project.Abstractions.Models;

namespace Project.Abstractions.Repositories
{
    public interface IProductRepository
    {
        void Add(IProduct product);
        IProduct[] GetAll();
        IProduct GetById(int productId);
    }
}
