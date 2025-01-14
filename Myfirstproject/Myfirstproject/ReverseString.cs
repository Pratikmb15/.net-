using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class ReverseString
    {
        public void ReversingString(String str) {
            String[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] Arr = words[i].ToCharArray();
                int left = 0, right = Arr.Length - 1;
                while (left < right)
                {
                    char temp = Arr[left];
                    Arr[left] = Arr[right];
                    Arr[right] = temp;
                    left++;
                    right--;
                }
                words[i] = new string(Arr); 
            }
            
            String Result = String.Join(" ", words);    
            Console.WriteLine(Result);  
        }
        
    }
}
