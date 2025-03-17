using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace MyFace.Helpers
{
public class HashAndSalt
{
    public static byte[] GetSalt()
    {
        byte[] salt = new byte[128 / 8];
        RandomNumberGenerator.Fill(salt);
        return salt;
    }
    public static string GetHashedPassword(string password, byte[] salt)
    {
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
        return hashed;
    }
}
}