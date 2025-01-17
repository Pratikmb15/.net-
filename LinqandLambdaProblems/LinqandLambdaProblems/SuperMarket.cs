using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    class Product
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public String Category { get; set; }
        public int Quantity { get; set; }
    }
    internal class SuperMarket
    {
        public static void Main(String[] args)
        {
            try
            {

                List<Product> Products = new List<Product>() {
            new Product{Id="22012",Name="Speaker",Price=2500,Category="Electronics",Quantity= 5},
            new Product{Id="10102",Name="Bread",Price=30,Category="Bakery",Quantity=30},
            new Product{Id="57023",Name="Milk",Price=72,Category="Dairy Products",Quantity=60},
            new Product{Id="22017",Name="HeadPhones",Price=700,Category="Electronics",Quantity= 9},
            new Product{Id="22012",Name="Soft Drinks",Price=40,Category="Beverages",Quantity=40},
            new Product{Id="46870",Name="Cheese",Price=150,Category="Dairy Products",Quantity=15}
           };

                var productWithquantitylessthan10 = Products.Where(x => x.Quantity < 10).OrderByDescending(x => x.Quantity);
                Console.WriteLine("Products having Quantity less than 10 are :");
                foreach (var pd in productWithquantitylessthan10)
                {
                    Console.WriteLine($"-{pd.Name} Quantity Left = {pd.Quantity} ");
                }
                Console.WriteLine();

                var TotalvalueOfProducts = Products.GroupBy(x => x.Category).Select(y => new { y.Key, Totalvalue = y.Sum(x => x.Price * x.Quantity) }).OrderByDescending(z => z.Totalvalue);
                foreach (var p in TotalvalueOfProducts)
                {
                    Console.WriteLine($"Total value of products in {p.Key} Category is {p.Totalvalue}rs");
                }

                Console.WriteLine();
                var productsgroupedBycategory = Products.GroupBy(x => x.Category);
                foreach (var catgry in productsgroupedBycategory)
                {
                    double cheapestPrice = catgry.Min(x => x.Price);
                    Product cheapestproduct = Products.Find(x => (x.Price == cheapestPrice) && (x.Category == catgry.Key));
                    Console.WriteLine($"Cheapest products in {catgry.Key} Category is {cheapestproduct.Name} having price of {cheapestPrice}rs");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
