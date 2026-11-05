using Microsoft.Data.SqlClient;

namespace FitnessCenterManagement.Data;

public static class DatabaseConnection
{
    private static readonly string connectionString =
        @"Server=(localdb)\MSSQLLocalDB;
          Database=FitnessCenterDB;
          Integrated Security=True;
          TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}