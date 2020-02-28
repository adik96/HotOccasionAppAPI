using Dapper;
using HotOccasionApp.DB.Entities;
using HotOccasionApp.DB.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Diagnostics;

namespace HotOccasionApp.DB.Repositories.Dapper
{
    public class DapperOccasionRepository : DapperBaseRepository, IDapperOccasionRepository
    {
        public DapperOccasionRepository(IConfiguration configuration, ILogger<DapperBaseRepository> logger) : base(configuration, logger) {}
        
        public Occasion GetOccasionByID(long id)
        {
            Stopwatch watch = new Stopwatch();
            var occasion = new Occasion();
            watch.Start();
            using (SqlConnection conn = new SqlConnection(this._connectionString))
            {
                conn.Open();
                occasion = conn.QuerySingle<Occasion>("SELECT * FROM Occasions WHERE Id = @ID", new { ID = id });
            }
            watch.Stop();
            this._logger.LogInformation(watch.ElapsedMilliseconds.ToString());
            return occasion;
        }
    }
}
