using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class ReadingandWritingString
    {
        public static void Main(String[] args) {
            String filePath3 = @"c:\Users\PratikBagul\C#Data\test4.txt";
            //File.CreateText(filePath3);
            //StreamWriter sw = new StreamWriter(filePath3);
             
            StreamWriter sw = File.CreateText(filePath3);

            sw.WriteLine("This is Random");
            sw.WriteLine("Sentence");
            sw.WriteLine("This is another Random Sentence");

            sw.Close();

            StreamReader sr = File.OpenText(filePath3);
            Console.WriteLine("Peek : {0}",Convert.ToChar(sr.Peek()));
            Console.WriteLine("FirstLine : {0}", sr.ReadLine());
            Console.WriteLine("EveryThing : {0}",sr.ReadToEnd());


        }
    }
}
