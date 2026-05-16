using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.Helpers
{
    public static class DatabaseHelper
    {
        public static SqlConnection CreateConnection()
        {
            var settings = ConfigurationManager.ConnectionStrings["GymDb"];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new InvalidOperationException(
                    "Connection string 'GymDb' is missing. Copy App.config.example to App.config and set your SQL Server instance.");
            }

            return new SqlConnection(settings.ConnectionString);
        }

        public static SqlCommand CreateCommand(string sql, SqlConnection connection)
        {
            return new SqlCommand(sql, connection);
        }

        public static SqlParameter Param(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }
    }
}
