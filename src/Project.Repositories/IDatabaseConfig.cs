namespace Project.Repositories
{
    public interface IDatabaseConfig
    {
        string ConnectionString { get; }
    }

    public class DatabaseConfig : IDatabaseConfig
    {
        public string ConnectionString
        {
            get { return "Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;"; }
        }
    }
}
