using System;
using static System.Console;
namespace Baekjoon
{
    public class main
    {
        public static void Main()
        {
            var d = Console.ReadLine().Split();
            int a = int.Parse(d[0]);
            int b = int.Parse(d[1]);
            int c;

            if ((a >= 0 && a < 24) && (0 <= b && b < 60))
            {
                if (b - 45 < 0)
                {
                    c = b - 45;
                    if (a > 0)
                    {
                        a--;
                    }
                    else
                    {
                        a = 23;
                    }
                    b = c + 60;
                }
                else
                {
                    b -= 45;
                }

            }
            Console.WriteLine(a + " " + b);
        }
    }
}
