using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace JLaboratories.Business
{
    public static class AESCrypto
    {
        // Key and IV should be 32 bytes and 16 bytes respectively for AES-256
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("0123456789ABCDEF0123456789ABCDEF");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("ABCDEF0123456789");

        public static string Encrypt(string plaintext)
        {
            using var aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;
            using var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            using (var sw = new StreamWriter(cs, Encoding.UTF8))
                sw.Write(plaintext);
            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string ciphertext)
        {
            var buffer = Convert.FromBase64String(ciphertext);
            using var aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;
            using var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream(buffer);
            using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            using var sr = new StreamReader(cs, Encoding.UTF8);
            return sr.ReadToEnd();
        }
    }
}
