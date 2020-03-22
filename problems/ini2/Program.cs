using System;

namespace ini2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 895;
            int b = 939;
            Console.WriteLine(Hypotenuse(a, b));
        }

        private static int Hypotenuse(int a, int b)
        {
            //Console.WriteLine(System.Math.Pow(a, 2) + System.Math.Pow(b, 2)); 
            return a * a + b * b;
        }
    }
}