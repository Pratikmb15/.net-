using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    public class Probnum5
    {
        public static void Main(String[] args)
        {
            try
            {
                Console.Write("Enter a String :");

                String str = Console.ReadLine();

                CheckVowels(str);
                String reversedString = ReverseString(str);
                Console.WriteLine($"Reversed String : {reversedString}");

                CheckifPalindrome(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static String CheckVowels(String inputStr)
        {
            String vowels = "AEIOUaeiou";
            String result = "";

            if (String.IsNullOrEmpty(inputStr))
            {
                Console.WriteLine("String is Empty !");
                return null;
            }
            else
            {
                foreach (char ch in inputStr)
                {
                    if (vowels.Contains(ch))
                    {
                        result += ch;
                    }
                }
                if (String.IsNullOrEmpty(result))
                {
                    Console.WriteLine("There are no Vowels in String ");
                }
                else
                {
                    Console.WriteLine($"The Vowels in String are : {result} ");
                }
                return result;

            }

        }
        public static String ReverseString(String Str)
        {
            if (String.IsNullOrEmpty(Str))
            {
               
                Console.WriteLine("String is empty !");
                return null;
            }
            char[] Arr = Str.ToCharArray();

            String reversedString = "";
            for (int i = Arr.Length - 1; i >= 0; i--)
            {
                reversedString += Arr[i];
            }
            return reversedString;
        }

        public static bool CheckifPalindrome(String input)
        {
            String reversedString = Probnum5.ReverseString(input);

            if (input == reversedString)
            {
                Console.WriteLine("String is Palindrome ");
                return true;
            }
            else
            {
                Console.WriteLine("String is not a Palindrome  ");
                return false;
            }

        }


    }
}
