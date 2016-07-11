using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_3
{
    class Program
    {
        static List<int> primes = new List<int>();
        static void Main(string[] args)
        {
            long prime = 600851475143;
            for (int i = 0; i < prime; i++)
            {
                prime = LoopThroughPrimes(prime);
                if (prime == 1) break;
            }
            Debug.WriteLine(primes.Last());
        }

        private static long LoopThroughPrimes(long prime)
        {
            for (int i = 2; i <= prime; i++)
            {
                decimal check = (decimal) prime/i;
                if (check%1 == 0)
                {
                    primes.Add(i);
                    return (long)check;
                }
            }
            return 0;
        }
    }
}
