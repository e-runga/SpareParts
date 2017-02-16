using System;
using System.Security.Cryptography;
using System.Text;

namespace SpareParts.Tools.Encryption
{
    /// <summary>
    /// The 3DES encryption/decryption helper
    /// </summary>
    public class TripleDESHelper
    {
        /// <summary>
        /// The Encryption key
        /// </summary>
        private const string ENCRYPTION_KEY = "88xGjTYT9m4Kqb78";

        /// <summary>
        /// Encrypts the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A 3DES encrypted string</returns>
        public static string Encrypt(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var inputArray = Encoding.UTF8.GetBytes(input);
                var tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = Encoding.UTF8.GetBytes(ENCRYPTION_KEY);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                var cryptoTransform = tripleDES.CreateEncryptor();
                var resultArray = cryptoTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();

                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Decrypts the specified input.
        /// </summary>
        /// <param name="input">The 3DES encrypted input</param>
        /// <returns>The decrypted string</returns>
        public static string Decrypt(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var inputArray = Convert.FromBase64String(input);
                var tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = Encoding.UTF8.GetBytes(ENCRYPTION_KEY);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                var cryptoTransform = tripleDES.CreateDecryptor();
                var resultArray = cryptoTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();

                return Encoding.UTF8.GetString(resultArray);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}