using System;

namespace ini3
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "RNFTnRA1zN0bedLWaTursiops5hUoZjWnLAw1Q9wcxJEhyxCQETRnp0Ry4WGih3qTS7zuEkH8z3PpdC96wgFpOS337fSjDQ95vE61l40LNuNL8msqwPJCKxhRhRZ3lD1hEl9kovUGc9PH6sZ5qJ9eMHpl9vEKMigXCEreinwardtiji";
            var a = 17;
            var b = 24;
            var c = 163;
            var d = 172;

            Console.WriteLine(Slice(s, a, b, c, d));
        }

        private static string Slice(string s, int a, int b, int c, int d)
        {
            return s.Substring(a, b - a + 1) + " " + s.Substring(c, d - c + 1);
        }
    }
}