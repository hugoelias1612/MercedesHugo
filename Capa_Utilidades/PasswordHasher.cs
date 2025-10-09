using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Utilidades
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
        public static bool VerifyPassword(string plainText, string hashedPassword)
        {
            return HashPassword(plainText) == hashedPassword;
        }
        public static bool IsHashed(string input)
        {
            // Ejemplo básico: verificar longitud típica de un hash SHA256
            return input.Length == 64 && System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-fA-F0-9]+$");
        }

    }
}
