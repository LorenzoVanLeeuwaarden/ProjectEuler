using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> list = TxtFileReader.TxtFileReader.ReadNumbersFile("numbers.txt");
            BigInteger result = list.Aggregate((currentSum, item) => currentSum + item);
            Debug.WriteLine(result.ToString().Substring(0,10));
        }
    }
}
