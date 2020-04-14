using System;
using System.IO;
using System.Linq;

namespace rna
{
    class Program
    {
        static string ReadFile()
        {
            string txt = File.ReadAllText(@"/home/debit/Downloads/rosalind_rna.txt");
            return txt;
        }
        
        static void WriteFile(string text)
        {
            File.WriteAllText(@"/home/debit/Downloads/rosalind_rna_resp.txt", text);
        }
        
        static void Main(string[] args)
        {
            string s = ReadFile();

            string resp = s.Replace('T', 'U');
            
            Console.Write(resp);
            
            WriteFile(resp);
        }
    }
}