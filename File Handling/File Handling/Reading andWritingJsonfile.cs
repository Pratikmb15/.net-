using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace File_Handling
{
    public class Purchase { 
    public string ProductName { get; set; }
    public DateTime PurchaseTime { get; set; }

    public double price { get; set; }
    
    }
    internal class Reading_andWritingJsonfile
    {
        public static void Main(String[] args) {
        
            Purchase purchase = new Purchase {
            ProductName ="Orange Juice",
            PurchaseTime = DateTime.Now,
            price= 60
            };

            string filePath = @"c:\Users\PratikBagul\C#Data\person.json";
            string jsonString = JsonSerializer.Serialize<Purchase>(purchase, new JsonSerializerOptions { WriteIndented =true });

            File.WriteAllText(filePath, jsonString);

            if (File.Exists(filePath))
            {

                string readedJsonString = File.ReadAllText(filePath);

                var rPurchase = JsonSerializer.Deserialize<Purchase>(readedJsonString);
                Console.WriteLine("Product Name : {0}", rPurchase.ProductName);
                Console.WriteLine("Product Time : {0}", rPurchase.PurchaseTime);
                Console.WriteLine("Product Price : {0}", rPurchase.price);
            }
            else 
            {
                Console.WriteLine("File not found !");
            }

        }
    }
}
