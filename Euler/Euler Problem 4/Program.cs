using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int highestPalindrome = 0;
            for (int a = 999; a >= 100; a--)
            {
                for (int b = 999; b >= 100; b--)
                {
                    if (IsPalindrome(a*b) && highestPalindrome < a*b)
                    {
                        highestPalindrome = a*b;
                    }
                }
            }
            Debug.WriteLine(highestPalindrome);
        }

        public static bool IsPalindrome(int number)
        {
            char[] chars = number.ToString().ToCharArray();
            Array.Reverse(chars);
            return number.ToString() == new string(chars);
        }
    }
}
