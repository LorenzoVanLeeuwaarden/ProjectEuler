using System;
using System.Collections.Generic;
using System.Linq;

namespace TxtFileReader
{
    public class TxtFileReader
    {
        static void Main(string[] args)
        {

        }

        public static List<List<int>> ReadFile(string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);

            return lines.Select(line => line.Split(' ')).Select(split => split.Select(number => Int32.Parse(number)).ToList()).ToList();
        }
    }
}
