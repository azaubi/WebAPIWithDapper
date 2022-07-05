
using System.Data.SqlClient;

namespace WebAPIWithDapper.Data.Repos
{
    public abstract class BaseRepo
    {
        protected string ConnectionString { get; private set; }

        protected BaseRepo(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection CreateConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
