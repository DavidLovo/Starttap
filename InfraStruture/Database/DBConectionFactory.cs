using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStruture.Database
{
    public class DBConectionFactory
    {
        private readonly string _connectionString;

        public DBConectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
