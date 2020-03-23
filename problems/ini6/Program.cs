using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ini6
{
    class Program
    {
        static string ReadFile()
        {
            string txt = File.ReadAllText(@"/home/debit/Downloads/rosalind_ini6.txt");
            return txt;
        }
        
        static void WriteFile(string text)
        {
            File.WriteAllText(@"/home/debit/Downloads/rosalind_ini6_resp.txt", text);
        }
        
        static void Main(string[] args)
        {
            string s = ReadFile();
            StringBuilder text = new StringBuilder();
            
            foreach (var word in CountWords(s))
            {
                text.AppendLine(word.Key + " " + word.Value);
            }
            
            WriteFile(text.ToString());
        }

        private static Dictionary<string, int> CountWords(string s)
        {
            Dictionary<string, int> dicWords = new Dictionary<string, int>();

            var splited = s.Trim().Split(" ");
            foreach (string word in splited)
            {
                if (!dicWords.ContainsKey(word))
                {
                    dicWords[word] = splited.Count(w=> w == word);
                }
            }

            return dicWords;
        }
    }
}