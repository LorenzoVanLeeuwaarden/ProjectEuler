using System.Diagnostics;
namespace Euler_Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 1000 / 3; a++)
            {
                for (int b = 1; b < 1000 / 2; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (a*a + b*b == c*c && a + b + c == 1000)
                        {
                            Debug.WriteLine(a * b * c);
                            return;
                        }
                    }
                }
            }
        }
    }
}
