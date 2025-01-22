using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Vowels
    {
        public void RemoveVowels(String str) {
            String vowels = "aeiouAEIOU";
            str = str.Trim();
            String Result =  "";
            foreach (Char ch in str)
            {
                if (!vowels.Contains(ch))
                {
                    Result += ch;
                }
            }

        Console.WriteLine(Result);

        }
    }
}
