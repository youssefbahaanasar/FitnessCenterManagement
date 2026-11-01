using Microsoft.Data.SqlClient;
using FitnessCenterManagement.Data;
using FitnessCenterManagement.Models;
using System.Data;

namespace FitnessCenterManagement.Services;

public class AuthService
{
    public async Task<User?> LoginAsync(
        string username,
        string password)
    {
        using var connection =
            DatabaseConnection.GetConnection();

        await connection.OpenAsync();

        const string sql = """
            SELECT UserId, Username, PasswordHash,
                   Role, IsActive
            FROM dbo.Users
            WHERE Username = @Username
            """;

        using var command = new SqlCommand(sql, connection);

        command.Parameters.Add(
            "@Username", SqlDbType.NVarChar, 50
        ).Value = username;

        using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
            return null;

        var user = new User
        {
            UserId = reader.GetInt32(0),
            Username = reader.GetString(1),
            PasswordHash = reader.GetString(2),
            Role = reader.GetString(3),
            IsActive = reader.GetBoolean(4)
        };

        if (!user.IsActive)
            return null;

        if (!PasswordHasher.Verify(password, user.PasswordHash))
            return null;

        // Never expose the hash to UI code
        user.PasswordHash = "";

        return user;
    }
}