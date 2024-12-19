using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorProject
{
    internal class Encryption
    {
        public static Random rand = new Random();
        public static string EncryptionMain(string msg)
        {
            int a = rand.Next(2, 8);
            long q = rand.Next(Convert.ToInt32(Math.Pow(10, 20)), Convert.ToInt32(Math.Pow(10, 50)));
            long g = rand.Next(2, Convert.ToInt32(q));

            long privateKey = genKey(q);
            long h = power(g, privateKey, q);

            var result = encrypt(msg, q, h, g);
            string encMsg = result.enc;
            long p = result.p;
            string decMsg = decrypt(encMsg, privateKey, privateKey, q);

            return decMsg;
        }

        public static long gcd(long a, long b)
        {
            if (a < b)
            {
                return gcd(b, a);
            }    
            else if (a % b == 0)
            {
                return b;
            }
            else
            {
                return gcd(b, (a % b));
            }    
        }

        //Generates large random numbers
        public static long genKey(long q)
        {
            double power = Math.Pow(10, 20);
            long key = rand.Next(Convert.ToInt32(power) , Convert.ToInt32(q));
            while (gcd(q, key) != 1)
            {
                key = rand.Next(Convert.ToInt32(power), Convert.ToInt32(q));
            }
            return key;
        }

        //Modular exponentiation
        public static long power(long a, long b, long c)
        {
            long x = 1;
            long y = a;
            while (b > 0)
            {
                if (b % 2 != 0)
                {
                    x = (x * y) % c;
                }
                y = (y * y) % c;
                b = Convert.ToInt32(b / 2);
            }
            return x % c;
        }

        // Asymmetric encyrption
        public static (string enc, long p) encrypt(string msg, long q, long h, long g)
        {
            string newMsg = "";
            long k = genKey(q); //Private key for sender
            long s = power(h, k, q);
            long p = power(g, k, q);
            for (int i = 0; i < msg.Length; i++)
            {
                newMsg = newMsg + msg[i];
            }
            string encrypted = "";
            for (int i = 0; i <= newMsg.Length; i++)
            {
                //encrypted[i, 0] = 'h';
                //encrypted.Substring(i, 0) = s * Char.GetNumericValue(encrypted[i]);

                double newChar = s * Char.GetNumericValue(newMsg[i]);
                encrypted = encrypted + newChar;
            }
            return (encrypted, p);
        }

        public static string decrypt(string encyrpted, long p, long key, long q)
        {
            string decrypted = "";
            long h = power(p, key, q);
            for (int i = 0; i <= encyrpted.Length; i++)
            {
                decrypted = decrypted + char.ConvertFromUtf32(Convert.ToInt32(encyrpted[i] / h));
            }
            return decrypted;
        }
    }
}
