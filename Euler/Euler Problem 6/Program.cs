using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfSquare = 0;
            double squareOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquare += Math.Pow(i, 2);
                squareOfSum += i;
            }

            Debug.WriteLine(Math.Pow(squareOfSum, 2) - sumOfSquare);
        }
    }
}
