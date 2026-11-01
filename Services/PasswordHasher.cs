using System.Security.Cryptography;

namespace FitnessCenterManagement.Services;

public static class PasswordHasher
{
    private const int Iterations = 600000;

    public static string Hash(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);

        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            Iterations,
            HashAlgorithmName.SHA256,
            32
        );

        return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
    }

    public static bool Verify(string password, string stored)
    {
        try
        {
            string[] parts = stored.Split('.');

            if (parts.Length != 3)
                return false;

            int iterations = int.Parse(parts[0]);

            if (iterations < 100000 || iterations > 2000000)
                return false;

            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] expected = Convert.FromBase64String(parts[2]);

            if (salt.Length != 16 || expected.Length != 32)
                return false;

            byte[] actual = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256,
                expected.Length
            );

            return CryptographicOperations.FixedTimeEquals(
                actual, expected
            );
        }
        catch (FormatException)
        {
            return false;
        }
        catch (OverflowException)
        {
            return false;
        }
    }
}