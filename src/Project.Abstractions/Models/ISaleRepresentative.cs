namespace Project.Abstractions.Models
{
    public interface ISaleRepresentative
    {
        int Id { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        int Age { get; set; }
    }

    public class SaleRepresentative : ISaleRepresentative
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
