using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Integer Number");
            //int num = int.Parse(Console.ReadLine());
            //SumOfEvenAndOdd sumOfEvenAndOdd = new SumOfEvenAndOdd();
            //sumOfEvenAndOdd.FindSum(num);  

            //Console.WriteLine("Enter Para1,Para2 and Shape");
            //double para1 = double.Parse(Console.ReadLine());
            //double para2 = double.Parse(Console.ReadLine());    
            //String shape = Console.ReadLine();

            //Shape shape1 = new Shape();
            //if (para2 == 0)
            //{
            //    shape1.findArea(para1, shape);
            //}
            //else {
            //    shape1.findArea(para1,para2,shape);
            //}


            //Console.WriteLine("Enter String :");
            //String str = Console.ReadLine();    
            //CountofVowelsandConsonants obj = new CountofVowelsandConsonants();
            //obj.FindVowelsandConsonantCount(str);

            //Console.WriteLine("Enter String :");
            //String str = Console.ReadLine();
            //Vowels obj2 = new Vowels();
            //obj2.RemoveVowels(str);

            Console.WriteLine("Enter Your Birth Year:");
            int BirthYear = int.Parse(Console.ReadLine());
            CalculateAge calculateAge = new CalculateAge();
            calculateAge.FindAge(BirthYear);







        }
    }
}
