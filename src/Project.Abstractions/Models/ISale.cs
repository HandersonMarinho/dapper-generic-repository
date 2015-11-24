using System;

namespace Project.Abstractions.Models
{
    public interface ISale
    {
        int Id { get; set; }
        DateTime Date { get; set; }
        bool IsShiped { get; set; }
        ISaleRepresentative SaleRepresentative { get; set; }
        IProduct[] Products { get; set; }
    }

    public class Sale : ISale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsShiped { get; set; }
        public ISaleRepresentative SaleRepresentative { get; set; }
        public IProduct[] Products { get; set; }
    }
}
