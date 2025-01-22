using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Example1
    {
        public static void Main(String[] args) {
            DirectoryInfo currDir = new DirectoryInfo(".");

            String DirPath = @"c:\Users\PratikBagul";

            DirectoryInfo PratikBagulDir = new DirectoryInfo(DirPath);

            if (!PratikBagulDir.Exists) 
            {
                Console.WriteLine($"The directory {DirPath} does not exist. Creating it now...");
                PratikBagulDir .Create();
                Console.WriteLine("Directory Created Succesfully ");


            }
            Console.WriteLine(PratikBagulDir.FullName); 
            Console.WriteLine(PratikBagulDir.Name); 
            Console.WriteLine(PratikBagulDir.Parent); 
            Console.WriteLine(PratikBagulDir.Attributes); 
            Console.WriteLine(PratikBagulDir.CreationTime); 

            String DataDirPath = Path.Combine(DirPath,"C#Data"); 
            DirectoryInfo DataDir = new DirectoryInfo(DataDirPath);
            if (!DataDir.Exists)
            {
                Console.WriteLine($"The directory {DataDirPath} does not exist. Creating it now...");
                DataDir.Create();
                Console.WriteLine("Directory Created Succesfully ");
            }
            String[] Customers = {
            "Jay Dixit",
            "Shreya Rathore",
            "Rajshree Patil",
            "Aryan Gupta"
            };

            String textFilePath = Path.Combine(DataDirPath,"test1.txt");

            File.WriteAllLines(textFilePath, Customers);
            Console.WriteLine($"File '{textFilePath}' created and data written successfully.");

            foreach (String Cust in File.ReadAllLines(textFilePath)) {
                Console.WriteLine($"Customer : {Cust} ");
            }

        }
    }
}
