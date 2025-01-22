using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using static File_Handling.Demojson;

namespace File_Handling
{
    internal class DemoCsv
    {
        public static void Main(String[] args)
        {
            string path = @"C:\Users\MILIND\source\repos\File Handling\File Handling\Democsv2.csv";
            var records = new List<Purchase>
            {
                new Purchase {ProductName= "Bread",price=35,PurchaseTime= DateTime.Now.AddMinutes(24) },
                new Purchase {ProductName= "Orange juice",price=60,PurchaseTime= DateTime.Now.AddDays(1) },
                new Purchase {ProductName= "Biscuit",price=40,PurchaseTime= DateTime.Now.AddHours(3) },
                new Purchase {ProductName= "Potato Chips",price=20,PurchaseTime= DateTime.Now },
            };
           
            
                //File.Create(path);
                //Console.WriteLine("File Successfully Created ");
            

            //Write data to csv file
            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }

            //Read data From csv file

            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var readedRecords = csvReader.GetRecords<Purchase>();
                foreach (var rec in readedRecords)
                {
                    Console.WriteLine($"Product Name : {rec.ProductName}, Price : {rec.price}, Purchase Time : {rec.PurchaseTime}");
                }
            }
        }
    }
}
