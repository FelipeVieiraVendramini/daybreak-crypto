using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DayBreakDesCrypto
{
    public static class DesHelper
    {
        private static readonly byte[] key =
        {
            61,
            222,
            139,
            117,
            59,
            144,
            192,
            131
        };
        private static readonly byte[] iv =
        {
            16,
            162,
            56,
            163,
            46,
            178,
            216,
            24
        };

        public static string Encrypt(string plainString)
        {
            if (plainString == null || plainString.Length == 0)
                throw new ArgumentException(nameof(plainString));
            using MemoryStream inStream = new MemoryStream(Encoding.UTF8.GetBytes(plainString));
            using MemoryStream outStream = new MemoryStream();
            Encrypt(inStream, outStream);
            return Convert.ToBase64String(outStream.ToArray());
        }

        public static void Encrypt(Stream inStream, Stream outStream)
        {
            DES des = (DES)new DESCryptoServiceProvider();
            CryptoStream cryptoStream = new CryptoStream(outStream, des.CreateEncryptor(key, iv), CryptoStreamMode.Write);
            byte[] buffer = new byte[1024];
            long num = 0;
            int count;
            for (long length = inStream.Length; num < length; num += (long)count)
            {
                count = inStream.Read(buffer, 0, 1024);
                cryptoStream.Write(buffer, 0, count);
            }
            cryptoStream.Close();
        }

        public static string Decrypt(string encryptString)
        {
            if (encryptString == null || encryptString.Length == 0)
                throw new ArgumentException(nameof(encryptString));
            using MemoryStream inStream = new MemoryStream(Convert.FromBase64String(encryptString));
            using MemoryStream outStream = new MemoryStream();
            Decrypt(inStream, outStream);
            return Encoding.UTF8.GetString(outStream.ToArray());
        }

        public static void Decrypt(Stream inStream, Stream outStream)
        {
            DES des = (DES)new DESCryptoServiceProvider();
            CryptoStream cryptoStream = new CryptoStream(outStream, des.CreateDecryptor(key, iv), CryptoStreamMode.Write);
            byte[] buffer = new byte[1024];
            long num = 0;
            int count;
            for (long length = inStream.Length; num < length; num += (long)count)
            {
                count = inStream.Read(buffer, 0, 1024);
                cryptoStream.Write(buffer, 0, count);
            }
            cryptoStream.Close();
        }
    }
}