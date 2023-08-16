using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Common.Utilities
{
    public class SecurityUtilities
    {


        private const int SaltValueSize = 16;
        /// <summary>
        /// 
        /// </summary>
        private static readonly string[] HashAlgorithms = new string[] { "SHA256", "SHA1", "MD5", "SHA512" };

        /// <summary>
        /// Verifies the hashed password.
        /// </summary>
        /// <param name="hashedPassword">The hashed password.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public static bool VerifyHashedData(string hashedText, string plainText)
        {
            try
            {
                string salt = hashedText.Substring(0, SaltValueSize * 2);
                //foreach (string hashAlgorithm in HashAlgorithms)
                {
                    string computedHash = HashData(plainText, salt);
                    if (string.Equals(computedHash, hashedText, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception exp)
            {
                // ErrorLogger.LogError(exp.Message, exp, false);
                return false;
            }
        }

        /// <summary>
        /// Hashes the data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="salt">The salt.</param>
        /// <param name="hashAlgorithm">The hash algorithm.</param>
        /// <returns></returns>
        public static string HashData(string plainText, string salt)
        {
            //if (hashAlgorithm == null)
            string hashAlgorithm = HashAlgorithms[0];
            Encoding encoding = Encoding.Unicode;
            //string salt = null;
            if (salt == null)
            {
                salt = Guid.NewGuid().ToString("N").Substring(0, SaltValueSize * 2);
            }
            int saltSize = string.IsNullOrEmpty(salt) ? 0 : salt.Length / 2;
            byte[] valueToHash = new byte[saltSize + encoding.GetByteCount(plainText)];
            for (int i = 0; i < saltSize; i++)
            {
                valueToHash[i] = byte.Parse(salt.Substring(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat);
            }
            encoding.GetBytes(plainText, 0, plainText.Length, valueToHash, saltSize);

            using (HashAlgorithm hash = HashAlgorithm.Create(hashAlgorithm))
            {
                byte[] hashValue = hash.ComputeHash(valueToHash);
                StringBuilder hashedText = new StringBuilder((hashValue.Length + saltSize) * 2);
                if (!string.IsNullOrEmpty(salt))
                    hashedText.Append(salt);

                foreach (byte hexdigit in hashValue)
                {
                    hashedText.AppendFormat(CultureInfo.InvariantCulture.NumberFormat, "{0:X2}", hexdigit);
                }
                return hashedText.ToString();
            }
        }
    }
}
