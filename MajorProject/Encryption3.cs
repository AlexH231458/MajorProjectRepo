using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTest2
{
    /*internal class Program
    {
        static Random random = new Random();

        static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (b == 0)
            {
                return a; //base case
            }
            if (a < b)
            {
                return GCD(b, a); //ensure a >= b
            }
            else if (a % b == 0)
            {
                return b;
            }
            else
            {
                return GCD(b, a % b);
            }
        }

        static int GenKey(int q)
        {
            int key = random.Next((int)Math.Pow(10, 20), q);
            while (GCD(q, key) != 1)
            {
                key = random.Next((int)Math.Pow(10, 20), q);
            }
            return key;
        }

        static long Power(long a, long b, long c)
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
                b /= 2;
            }
            return x % c;
        }

        static (List<long>, long) Encrypt(string msg, int q, long h, long g)
        {
            List<long> en_msg = new List<long>();
            int k = GenKey(q);
            long s = Power(h, k, q);
            long p = Power(g, k, q);

            Console.WriteLine("g^k used : " + p);
            Console.WriteLine("g^ak used : " + s);

            foreach (char c in msg)
            {
                en_msg.Add(s * c);
            }

            return (en_msg, p);
        }

        static string Decrypt(List<long> en_msg, long p, int key, int q)
        {
            List<char> dr_msg = new List<char>();
            long h = Power(p, key, q);

            foreach (long c in en_msg)
            {
                dr_msg.Add((char)(c / h));
            }

            return new string(dr_msg.ToArray());
        }*/

    /*
        static void newmain()
        {
            Console.WriteLine("Original Message: ");
            string msg = Console.ReadLine();

            BigInteger min = BigInteger.Pow(10, 2);
            BigInteger max = BigInteger.Pow(10, 5);

            BigInteger a = getLargeNumber(min, max);
            BigInteger b = getLargeNumber(2, a);

            int q = (int)a;
            int g = (int)b;

            int key = GenKey(q);
            long h = Power(g, key, q);
            Console.WriteLine("g used : " + g);
            Console.WriteLine("g^a used : " + h);

            var (en_msg, p) = Encrypt(msg, q, h, g);
            string dmsg = Decrypt(en_msg, p, key, q);
            Console.WriteLine("Decrypted Message : " + dmsg);
            Console.ReadLine();
        }
        static BigInteger getLargeNumber(BigInteger min, BigInteger max)
        {
            byte[] bytes = max.ToByteArray();
            BigInteger result;
            do
            {
                random.NextBytes(bytes);
                result = new BigInteger(bytes);
            }
            while (result < min || result >= max);
            return result;
        }
    }*/
}
