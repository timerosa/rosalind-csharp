using System;

namespace ini2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(hypotenuse(3, 5));
        }

        static int hypotenuse(int a, int b)
        {
            //Console.WriteLine(System.Math.Pow(a, 2) + System.Math.Pow(b, 2)); 
            return a * a + b * b;
        }
    }
}