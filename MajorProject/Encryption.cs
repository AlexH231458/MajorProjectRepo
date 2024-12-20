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
            int q = rand.Next(Convert.ToInt32(Math.Pow(10, 2)), Convert.ToInt32(Math.Pow(10, 5)));
            int g = rand.Next(2, Convert.ToInt32(q));

            int privateKey = genKey(q);
            int h = power(g, privateKey, q);

            var result = encrypt(msg, q, h, g);
            string encMsg = result.enc;
            int p = result.p;
            string decMsg = decrypt(encMsg, privateKey, privateKey, q);

            return decMsg;
        }

        public static int gcd(int a, int b)
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
        public static int genKey(int q)
        {
            int power = (int)Math.Pow(10, 2);
            int key = rand.Next(power, q);
            while (gcd(q, key) != 1)
            {
                key = rand.Next(power, q);
            }
            return key;
        }

        //Modular exponentiation
        public static int power(int a, int b, int c)
        {
            int x = 1;
            int y = a;
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
        public static (string enc, int p) encrypt(string msg, int q, int h, int g)
        {
            string newMsg = "";
            int k = genKey(q); //Private key for sender
            int s = power(h, k, q);
            int p = power(g, k, q);
            for (int i = 0; i < msg.Length; i++)
            {
                newMsg = newMsg + msg[i];
            }
            string encrypted = "";
            for (int i = 0; i < newMsg.Length; i++)
            {
                //encrypted[i, 0] = 'h';
                //encrypted.Substring(i, 0) = s * Char.GetNumericValue(encrypted[i]);

                double newChar = s * Char.GetNumericValue(newMsg[i]);
                encrypted = encrypted + newChar;
            }
            return (encrypted, p);
        }

        public static string decrypt(string encyrpted, int p, int key, int q)
        {
            string decrypted = "";
            int h = power(p, key, q);
            for (int i = 0; i < encyrpted.Length; i++)
            {
                decrypted = decrypted + char.ConvertFromUtf32(Convert.ToInt32(encyrpted[i] / h));
            }
            return decrypted;
        }

        //copied
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTest
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter message to encyrpt: ");
                string msgToEnc = Console.ReadLine();
                string result = (msgToEnc);
                Console.WriteLine("Decrypted: " + result);
                Console.ReadLine();
            }

            public static Random rand = new Random();
            public char[] tinyAlphabet = { 'G', 'a', 'e', 'L', '$', '-', 'S', '!', '#', 'C' };

            public static string encode(int num)
            {
                string result = "";
                string newNum = Convert.ToString(num);
                for (int i = 0; i < newNum.Length; i++)
                {
                    result = result + tinyAlphabet[i];
                }
                return result;
            }

            public static string encrypt(string msg, int pub)
            {
                string encMsg = "";
                for (int i = 0; i < msg.Length; i++)
                {
                    int num = pub * msg[i];
                    encMsg = encMsg + encode(num);
                }
                return encMsg;
            }

            public static string decode(string block)
            {
                string num;
                for (int i = 0; i < block.Length; i++)
                {
                    num = num + tinyAlphabet[i];
                }
                return num;
            }

            public static string decrypt(string msg)
            {
                string decMsg = "";

            }

            public static (int priv, int pub) genPubPrivKeys()
            {
                int q = rand.Next(2, 997);
                int g = rand.Next(7, q);
                int k = genKey(q);
                int h = modPow(g, k, q);
                int publicKey = pubKeyGen(h, k, q);

                int p = modPow(g, k, q);
                h = modPow(g, k, q);
                int privateKey = privKeyGen(h);

                return (privateKey, publicKey);
            }

            public static int privKeyGen(int a)
            {
                return a;
            }

            public static int pubKeyGen(int a, int b, int c)
            {
                return modPow(a, b, c);
            }

            public static int genKey(int q)
            {
                int key = rand.Next(1, q);
                while (GDC(q, key) != 1)
                {
                    key = rand.Next(1, q);
                }
                return key;
            }

            public static int GDC(int a, int b)
            {
                if (a < b)
                {
                    return GDC(b, a);
                }
                if (a % b == 0)
                {
                    return b;
                }
                return GDC(b, (a % b));
            }

            public static int modPow(int a, int b, int c)
            {
                int x = 1;
                int y = a;
                while (b > 0)
                {
                    if ((b % 2) == 0)
                    {
                        x = (x * y) % c;
                    }
                    y = (y * y) % c;
                    b = b / 2;
                }
                return (x % c);
            }
        }
    }
}
}
