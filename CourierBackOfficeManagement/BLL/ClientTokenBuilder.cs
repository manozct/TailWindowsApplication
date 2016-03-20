using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Globalization;

/// <summary>
/// Summary description for TokenEncript
/// </summary>
/// 
namespace CourierManagement
{
    public class ClientTokenBuilder
    {
        public static  string BuildTokens()
        {
            string Salt = "mnlk";
            string dName = "DiskTop";
            string dUser = "LoginName";
            string DTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture);
            string finalToken = dName + "|" + dUser + "|" + DTime + "|" + Salt;
            finalToken = TokenCleintEncrypt.Encrypt(finalToken);
            return finalToken;
        }
    }
    public class TokenCleintEncrypt
    {
        public static string passPhrase = "UniquePhr@ge";
        public static string saltValue = "s@1tV@lue";
        public static string hashAlgorithm = "SHA1";
        public static int passwordIterations = 2;
        public static string initVector = "@1B2c3D4e5F6g7H8";
        public static int keySize = 256;

        public static string Encrypt(string plainText)
        {
            string cipherText = "";
            if (plainText.Length <= 0)
            {
                return cipherText;
            }
            try
            {
                // Convert strings into byte arrays.
                // Let us assume that strings only contain ASCII codes.
                // If strings include Unicode characters, use Unicode, UTF7, or UTF8 
                // encoding.
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

                // Convert our plaintext into a byte array.
                // Let us assume that plaintext contains UTF8-encoded characters.
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

                // First, we must create a password, from which the key will be derived.
                // This password will be generated from the specified passphrase and 
                // salt value. The password will be created using the specified hash 
                // algorithm. Password creation can be done in several iterations.
                PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                                passPhrase,
                                                                saltValueBytes,
                                                                hashAlgorithm,
                                                                passwordIterations);

                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes = password.GetBytes(keySize / 8);

                // Create uninitialized Rijndael encryption object.
                RijndaelManaged symmetricKey = new RijndaelManaged();

                // It is reasonable to set encryption mode to Cipher Block Chaining
                // (CBC). Use default options for other symmetric key parameters.
                symmetricKey.Mode = CipherMode.CBC;

                // Generate encryptor from the existing key bytes and initialization 
                // vector. Key size will be defined based on the number of the key 
                // bytes.
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
                                                                 keyBytes,
                                                                 initVectorBytes);

                // Define memory stream which will be used to hold encrypted data.
                MemoryStream memoryStream = new MemoryStream();

                // Define cryptographic stream (always use Write mode for encryption).
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                             encryptor,
                                                             CryptoStreamMode.Write);
                // Start encrypting.
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                // Finish encrypting.
                cryptoStream.FlushFinalBlock();

                // Convert our encrypted data from a memory stream into a byte array.
                byte[] cipherTextBytes = memoryStream.ToArray();

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert encrypted data into a base64-encoded string.
                cipherText = Convert.ToBase64String(cipherTextBytes);
            }
            catch
            {
                // Return decrypted string.   
                return cipherText;
            }
            // Return decrypted string.   
            return cipherText;
        }
    }
}