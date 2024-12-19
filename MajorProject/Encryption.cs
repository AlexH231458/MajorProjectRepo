using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorProject
{
    internal class Encryption
    {
        public static Random rand = new Random();
        public static void Encrypt()
        {
            int a = rand.Next(2, 8);
        }

        public long gcd(long a, long b)
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
        public long genKey(long q)
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
        public long power(long a, long b, long c)
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
        public string encrypt(string msg, long q, long h, long g)
        {
            string encrypted = "";
            long k = genKey(q); //Private key for sender
            long s = power(h, k, q);
            long p = power(g, k, q);
            for (int i = 0; i < msg.Length; i++)
            {
                encrypted = encrypted + msg[i];
            }
            for (int i = 0; i <= encrypted.Length; i++)
            {
                encrypted[i] = s * Char.GetNumericValue(encrypted[i]);
            }
            //return en_msg, p;
        }
    }
}
