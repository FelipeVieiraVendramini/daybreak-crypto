using System.Security.Cryptography;
using System.Text;

namespace DayBreakDesCrypto
{
    public static class MD5Util
    {
        public static byte[] MD5(byte[] originalData) => new MD5CryptoServiceProvider().ComputeHash(originalData);

        public static string MD5(string originalData, Encoding encoding)
        {
            byte[] numArray = encoding != null ? MD5(encoding.GetBytes(originalData)) : throw new ArgumentNullException("Encoding");
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte num in numArray)
                stringBuilder.AppendFormat("{0:x2}", (object)num);
            return stringBuilder.ToString();
        }
    }
}
