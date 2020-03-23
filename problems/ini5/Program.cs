using System;
using System.IO;

namespace ini5
{
    class Program
    {
        static string ReadFile()
        {
            string txt = File.ReadAllText(@"/home/debit/Downloads/rosalind_ini5.txt");
            return txt;
        }
        
        static void Main(string[] args)
        {
            string s = ReadFile();
            Console.WriteLine(EvenLines(s));
        }

        private static string EvenLines(string s)
        {
            string lines = "";
            int index = 1;
            foreach (var line in s.Split("\n"))
            {
                if (index % 2 == 0)
                {
                    lines += line + "\n";
                }
                index++;
            }

            return lines;
        }
    }
}