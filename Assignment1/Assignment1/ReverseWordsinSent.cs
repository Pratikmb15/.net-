using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ReverseWordsinSent
    {
        public static void Main(String[] args) {
            //Console.WriteLine("Enter the Sentence to be reversed :");
            //String Sentence = Console.ReadLine();
            String Sentence = "Hello Pce Panvel";
              String[] arr = Sentence.Split(' ');
            for(int i=arr.Length-1;i>=0;i--){
                Console.Write($"{arr[i]} ");

            }
        }
    }
}
