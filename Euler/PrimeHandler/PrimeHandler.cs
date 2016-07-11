using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHandler
{
    public class PrimeHandler
    {
        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
