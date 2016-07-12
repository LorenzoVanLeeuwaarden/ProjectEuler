using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> grid = TxtFileReader.TxtFileReader.ReadFile("grid.txt");
            List<int> values = new List<int>
            {
                CheckVert(grid),
                CheckDiagRight(grid),
                CheckDiagLeft(grid),
                CheckHor(grid)
            };

            Debug.WriteLine(values.Max());
        }

        private static int CheckDiagRight(List<List<int>> grid)
        {
            int sum = 0;
            for (int y = 0; y < grid[0].Count - 3; y++)
            {
                for (int x = 0; x < grid[0].Count - 3; x++)
                {
                    var currentSum = grid[x][y] * grid[x + 1][y + 1] * grid[x + 2][y + 2] * grid[x + 3][y + 3];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }
            return sum;
        }

        private static int CheckDiagLeft(List<List<int>> grid)
        {
            int sum = 0;
            for (int y = 0; y < grid[0].Count - 3; y++)
            {
                for (int x = 19; x > 3; x--)
                {
                    var currentSum = grid[x][y] * grid[x - 1][y + 1] * grid[x - 2][y + 2] * grid[x - 3][y + 3];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }
            return sum;
        }

        public static int CheckVert(List<List<int>> grid)
        {
            int sum = 0;
            for (int y = 0; y < grid[0].Count - 3; y++)
            {
                for (int x = 0; x < grid[0].Count - 3; x++)
                {
                    var currentSum = grid[x][y]*grid[x + 1][y]*grid[x + 2][y]*grid[x + 3][y];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }
            return sum;
        }

        public static int CheckHor(List<List<int>> grid)
        {
            int sum = 0;
            for (int y = 0; y < grid[0].Count - 3; y++)
            {
                for (int x = 0; x < grid[0].Count - 3; x++)
                {
                    var currentSum = grid[y][x] * grid[y][x + 1] * grid[y][x + 2] * grid[y][x + 3];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }
            return sum;
        }

    }
}
