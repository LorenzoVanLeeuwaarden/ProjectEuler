using System;
using System.Diagnostics;

namespace Euler_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Tuple<int, int> previous = new Tuple<int, int>(0,1);
            while(previous.Item2 < 4000000)
            {
                int current = previous.Item1 + previous.Item2;
                if (current % 2 == 0)
                {
                    sum += current;
                }
                previous = new Tuple<int, int>(previous.Item2, current);
            }
            Debug.WriteLine(sum);
        }
    }
}
