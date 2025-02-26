//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Security.Cryptography;

//namespace EncryptionTest
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
//                {
//                    string pubKey = RSA.ToXmlString(false);
//                    string priKey = RSA.ToXmlString(true);
//                    Console.Write("Enter text to encrypt: ");
//                    string message = Console.ReadLine();
//                    byte[] messageArray = Encoding.UTF8.GetBytes(message);
//                    byte[] encryptedArray = RSA.Encrypt(messageArray, false);
//                    string encryptedMessage = Convert.ToBase64String(encryptedArray);
//                    Console.WriteLine("Encrypted message: " + encryptedMessage);
//                    byte[] decryptedArray = RSA.Decrypt(encryptedArray, false);
//                    string decryptedMessage = Encoding.UTF8.GetString(decryptedArray);
//                    Console.WriteLine("Decrypted message: " + decryptedMessage);
//                }
//            }
//            catch (CryptographicException exception)
//            {
//                Console.WriteLine("Error");
//            }
//            catch (Exception exception)
//            {
//                Console.WriteLine("Error");
//            }
//            Console.ReadLine();
//        }
//    }
//}