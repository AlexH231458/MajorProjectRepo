using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorProject
{
    internal class Encryption
    {
        Random rand = new Random();
        public static void Encrypt()
        {
            int a = rand.Next(2, 8);
        }

        public long gcd(int a, int b)
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

        public long genKey(int q)
        {
            long key = rand.Next(math.pow(10, 20))
        }
    }
}
