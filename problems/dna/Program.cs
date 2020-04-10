using System;
using System.IO;
using System.Linq;

namespace dna
{
    class Program
    {
        static string ReadFile()
        {
            string txt = File.ReadAllText(@"/home/debit/Downloads/rosalind_dna.txt");
            return txt;
        }
        
        static void WriteFile(string text)
        {
            File.WriteAllText(@"/home/debit/Downloads/rosalind_dna_resp.txt", text);
        }
        
        static void Main(string[] args)
        {
            string s = ReadFile();

            string resp = s.Count(c => c.Equals('A')).ToString() + ' ' +
                          s.Count(c => c.Equals('C')).ToString() + ' ' +
                          s.Count(c => c.Equals('G')).ToString() + ' ' +
                          s.Count(c => c.Equals('T')).ToString();
            
            Console.Write(resp);
            
            WriteFile(resp);
        }
    }
}