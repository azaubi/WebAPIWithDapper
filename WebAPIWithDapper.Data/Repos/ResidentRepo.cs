using Dapper;
using Microsoft.Extensions.Configuration;
using WebAPIWithDapper.Data.Models;

namespace WebAPIWithDapper.Data.Repos
{
    public interface IResidentRepo
    {
        Task<IEnumerable<Resident>> Get();
    }

    public class ResidentRepo : BaseRepo, IResidentRepo
    {
        public ResidentRepo(IConfiguration configuration) :
            base(configuration.GetConnectionString("FoxenConnectionString"))
        {
        }

        public async Task<IEnumerable<Resident>> Get()
        {
            using (var conn = CreateConnection())
            {
                var results = await conn.QueryAsync<Resident>("SELECT * FROM [dbo].[Residents]");
                return results;
            }
        }
    }
}
