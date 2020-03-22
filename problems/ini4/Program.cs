using System;

namespace ini4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4799;
            var b = 9725;

            Console.WriteLine(Odds(a, b));
        }

        private static int Odds(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}