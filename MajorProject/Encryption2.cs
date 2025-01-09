using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.StringSplitOptions;
using System.Net.NetworkInformation;

namespace MajorProject
{
    internal class Encryption2
    {
        private const char SEP = 'A';
        public static Random rand = new Random();
        static readonly char[] tinyAlphabet = { 'G', 'a', 'e', 'L', '$', '-', 'S', '!', '#', 'C' };

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
                encMsg = encMsg + $"{encode(num)}{SEP}";
            }
            return encMsg;
        }

        public static string decode(string block)
        {
            string num = "";
            for (int i = 0; i < block.Length; i++)
            {
                num = num + Array.IndexOf(tinyAlphabet, i);
            }
            return num;
        }

        public static string decrypt(string msg, int priKey)
        {
            string decMsg = "";
            var blocks = msg.Split(new[] { SEP }, RemoveEmptyEntries);
            foreach (var b in blocks)
            {
                int decBlock = int.Parse(decode(b));
                int num = (char)(decBlock / priKey);
                decMsg = decMsg + $"{num}";
            }
            return decMsg;
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
        static void Main(string[] args)
        {
            Console.Write("Enter message to encyrpt: ");
            string msgToEnc = Console.ReadLine();
            var keys = genPubPrivKeys();
            int pub = keys.pub;
            int priv = keys.priv;
            string encrypted = encrypt(msgToEnc, pub);
            Console.WriteLine("Encrypted message: " + encrypted);
            Console.WriteLine("Public key: " + pub);
            Console.WriteLine("Private key: " + priv);
            string decrypted = decrypt(encrypted, priv);
            Console.WriteLine("Decrypted: " + decrypted);
            Console.ReadLine();
        }
    }
}
    