namespace Project.Abstractions.Models
{
    public interface IProduct
    {
        int Id { get; set; }
        string Description { get; set; }
        double Price { get; set; }
    }

    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
