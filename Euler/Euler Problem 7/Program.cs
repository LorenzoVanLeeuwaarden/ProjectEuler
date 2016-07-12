using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int primesfound = 1;
            for (int i = 3; i < int.MaxValue; i = i + 2)
            {
                if (PrimeHandler.PrimeHandler.IsPrime(i)) primesfound++;
                if (primesfound == 10001)
                {
                    Debug.WriteLine(i);
                    break;
                }
            }
        }
    }
}
