using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class CountofVowelsandConsonants
    {
       int VowelsCount = 0;
       int ConsonantsCount = 0;

        public void FindVowelsandConsonantCount(String str) {

            String vowels = "aeiouAEIOU";
            str = str.Trim();   

            foreach (Char ch in str) 
            {
                if (vowels.Contains(ch))
                {
                    VowelsCount++;
                }
                else 
                { 
                    ConsonantsCount++;
                }

            }
            Console.WriteLine($"The number of Vowels in String is {VowelsCount}");
            Console.WriteLine($"The number of Consonants in String is {ConsonantsCount}");

        }

    }
}
