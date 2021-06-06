using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Driver Ado.net => SQL Server
using Microsoft.Extensions.Configuration;

namespace DAL.UOW
{
    sealed class DbSession : IDisposable
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public DbSession(IConfiguration configuration, string connectionName)
        {
            Connection = new SqlConnection(configuration.GetConnectionString(connectionName));
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}
