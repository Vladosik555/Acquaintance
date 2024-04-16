using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Acquaintance
{
    internal class Hash
    {
        public string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public bool VerifyMD5Hash(string input, string hash)
        {
            string hashOfInput = CalculateMD5Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ReverseHash(string hashedString)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = new byte[hashedString.Length / 2];
                for (int i = 0; i < hashedString.Length; i += 2)
                {
                    hashBytes[i / 2] = Convert.ToByte(hashedString.Substring(i, 2), 16);
                }

                byte[] inputBytes = md5.TransformFinalBlock(hashBytes, 0, hashBytes.Length);
                return Encoding.UTF8.GetString(inputBytes);
            }
        }
    }
}
