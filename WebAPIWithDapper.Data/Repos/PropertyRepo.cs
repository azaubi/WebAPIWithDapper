using Dapper;
using Microsoft.Extensions.Configuration;
using WebAPIWithDapper.Data.Models;

namespace WebAPIWithDapper.Data.Repos
{
    public interface IPropertyRepo
    {
        Task<IEnumerable<Property>> Get();
    }

    public class PropertyRepo : BaseRepo, IPropertyRepo
    {
        public PropertyRepo(IConfiguration configuration) :
            base(configuration.GetConnectionString("FoxenConnectionString"))
        {
        }

        public async Task<IEnumerable<Property>> Get()
        {
            using (var conn = CreateConnection())
            {
                var results = await conn.QueryAsync<Property>("SELECT * FROM [dbo].[Properties]");
                return results;
            }
        }
    }
}
