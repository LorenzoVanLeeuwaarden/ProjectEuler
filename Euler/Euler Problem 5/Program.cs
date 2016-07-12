using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2521; i < int.MaxValue; i++)
            {
                bool evenlyDivisible = true;
                for (int b = 2; b < 20; b++)
                {
                    if (i%b != 0)
                    {
                        evenlyDivisible = false;
                    }
                }
                if (evenlyDivisible)
                {
                    Debug.WriteLine(i);
                    return;
                }
            }
        }
    }
}
