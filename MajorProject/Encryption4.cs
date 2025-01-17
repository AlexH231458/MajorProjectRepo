//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace MajorProject
//{
//    internal class Encryption4
//    {
//        // Method to generate RSA public and private keys
//        public static (string publicKey, string privateKey) GenerateRSAKeys()
//        {
//            using (RSA rsa = new RSACryptoServiceProvider(2048)) // 2048-bit key size for security
//            {
//                string publicKey = rsa.ToXmlString(false);  // Public key (only modulus and exponent)
//                string privateKey = rsa.ToXmlString(true);  // Private key (includes both modulus and private exponent)
//                return (publicKey, privateKey);
//            }
//        }

//        // Encrypt a message using the public key
//        public static string Encrypt(string plainText, string publicKey)
//        {
//            using (RSA rsa = new RSACryptoServiceProvider())
//            {
//                rsa.FromXmlString(publicKey); // Load the public key
//                byte[] data = Encoding.UTF8.GetBytes(plainText); // Convert the plaintext message to bytes
//                byte[] encryptedData = rsa.Encrypt(data); // Encrypt the data using the public key
//                return Convert.ToBase64String(encryptedData); // Return the encrypted data as a Base64 string
//            }
//        }

//        // Decrypt a message using the private key
//        public static string Decrypt(string cipherText, string privateKey)
//        {
//            using (RSA rsa = new RSACryptoServiceProvider())
//            {
//                rsa.FromXmlString(privateKey); // Load the private key
//                byte[] encryptedData = Convert.FromBase64String(cipherText); // Convert the Base64 string to bytes
//                byte[] decryptedData = rsa.Decrypt(encryptedData); // Decrypt the data using the private key
//                return Encoding.UTF8.GetString(decryptedData); // Return the decrypted data as a string
//            }
//        }

//        // Main method to run the encryption and decryption
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Generating RSA public and private keys...");
//            var keys = GenerateRSAKeys();
//            string publicKey = keys.publicKey;
//            string privateKey = keys.privateKey;

//            Console.Write("Enter the message to encrypt: ");
//            string plainText = Console.ReadLine();

//            // Encrypt the message using the public key
//            string encryptedMessage = Encrypt(plainText, publicKey);
//            Console.WriteLine("Encrypted Message: " + encryptedMessage);

//            // Decrypt the message using the private key
//            string decryptedMessage = Decrypt(encryptedMessage, privateKey);
//            Console.WriteLine("Decrypted Message: " + decryptedMessage);

//            Console.ReadLine();
//        }
//    }
//}
