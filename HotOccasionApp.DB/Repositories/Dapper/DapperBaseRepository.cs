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
    public class DapperBaseRepository
    {
        public IConfiguration _configuration;
        public string _connectionString;
        public readonly ILogger<DapperBaseRepository> _logger;
        public DapperBaseRepository(IConfiguration configuration, ILogger<DapperBaseRepository> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _connectionString = _configuration.GetConnectionString("HotOccasionAppDBConnection");
        }
    }
}
