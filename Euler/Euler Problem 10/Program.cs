using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Euler_Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 2; i < 2000000; i++)
            {
                if (PrimeHandler.PrimeHandler.IsPrime(i)) sum += i;
            }
            Debug.WriteLine(sum);
        }
    }
}
