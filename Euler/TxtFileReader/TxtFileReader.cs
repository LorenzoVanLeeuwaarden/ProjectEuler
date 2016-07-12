using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace TxtFileReader
{
    public class TxtFileReader
    {
        static void Main(string[] args)
        {

        }

        public static List<List<int>> ReadTxtFile(string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);

            return lines.Select(line => line.Split(' ')).Select(split => split.Select(number => Int32.Parse(number)).ToList()).ToList();
        }

        public static List<BigInteger> ReadNumbersFile(string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);

            return lines.Select(line => BigInteger.Parse(line)).ToList();
        }
    }
}
