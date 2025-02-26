//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.IO;
//using System.Threading.Tasks;

//namespace NewTesEnc
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter text: ");
//            string original = Console.ReadLine();
//            byte[] encrypted;
//            string decrypted;
//            string keyBase64;
//            string ivBase64;

//            using (Aes aes = Aes.Create())
//            {
//                // Encrypt the string
//                encrypted = EncryptStringToBytes(original, aes.Key, aes.IV);
//                Console.WriteLine("Encrypted: {0}", Convert.ToBase64String(encrypted));

//                keyBase64 = Convert.ToBase64String(aes.Key);
//                ivBase64 = Convert.ToBase64String(aes.IV);
//            }

//            byte[] key = Convert.FromBase64String(keyBase64);
//            byte[] iv = Convert.FromBase64String(ivBase64);

//            // Decrypt the bytes
//            decrypted = DecryptStringFromBytes(encrypted, key, iv);
//            Console.WriteLine("Decrypted: {0}", decrypted);
//            Console.ReadLine();
//        }

//        static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
//        {
//            byte[] encrypted;

//            // Create an Aes object with the specified key and IV.
//            using (Aes aes = Aes.Create())
//            {
//                aes.Key = key;
//                aes.IV = iv;

//                // Create a new MemoryStream object to contain the encrypted bytes.
//                using (MemoryStream memoryStream = new MemoryStream())
//                {
//                    // Create a CryptoStream object to perform the encryption.
//                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
//                    {
//                        // Encrypt the plaintext.
//                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
//                        {
//                            streamWriter.Write(plainText);
//                        }

//                        encrypted = memoryStream.ToArray();
//                    }
//                }
//            }

//            return encrypted;
//        }

//        static string DecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] iv)
//        {
//            string decrypted;

//            // Create an Aes object with the specified key and IV.
//            using (Aes aes = Aes.Create())
//            {
//                aes.Key = key;
//                aes.IV = iv;

//                // Create a new MemoryStream object to contain the decrypted bytes.
//                using (MemoryStream memoryStream = new MemoryStream(cipherText))
//                {
//                    // Create a CryptoStream object to perform the decryption.
//                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
//                    {
//                        // Decrypt the ciphertext.
//                        using (StreamReader streamReader = new StreamReader(cryptoStream))
//                        {
//                            decrypted = streamReader.ReadToEnd();
//                        }
//                    }
//                }
//            }

//            return decrypted;
//        }
//    }
//}