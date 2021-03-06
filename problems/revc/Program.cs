﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace revc
{
    class Program
    {
        static string ReadFile()
        {
            string txt = File.ReadAllText(@"/home/debit/Downloads/rosalind_revc.txt");
            return txt;
        }
        
        static void WriteFile(string text)
        {
            File.WriteAllText(@"/home/debit/Downloads/rosalind_revc_resp.txt", text);
        }
        
        static void Translate(ref string dna)
        {
            var map = new string[] {"AGTC", "TCAG"};
            dna = string.Join("", dna.Select(c => map[1][map[0].IndexOf(c)]).Reverse());
        }
        
        static void Main(string[] args)
        {
            string s = ReadFile().Trim();

            Translate(ref s);
            
            //medir velocidade
            //StringBuilder sb = new StringBuilder();
            // foreach (char bp in s.Reverse())
            // {
            //     switch (bp)
            //     {
            //         case 'A': sb.Append('T');
            //             break;
            //         case 'G': sb.Append('C');
            //             break;
            //         case 'T': sb.Append('A');
            //             break;
            //         case 'C': sb.Append('G');
            //             break;
            //     }
            // }
            //string resp = sb.ToString();

            Console.Write(s);
            
            WriteFile(s);
        }
    }
}