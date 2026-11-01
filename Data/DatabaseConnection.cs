using Microsoft.Data.SqlClient;

namespace FitnessCenterManagement.Data;

public static class DatabaseConnection
{
    private static readonly string ConnectionString =
        @"Server=(localdb)\MSSQLLocalDB;
          Database=FitnessCenterDB;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}