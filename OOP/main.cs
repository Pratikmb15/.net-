using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class main

    { 
        public static void Main()
        {
  //Inheritence Example
            //Admin obj = new Admin();
            //obj.admin("Software Dev", 50000);
            //obj.display();

            //Employee obj1 = new Employee();
            //obj1.admin("Data Scientist", 35000);
            //obj1.display();
            //obj1.employee("Mumbai");
            //obj1.display1();

   //Encapsulation Example
            ////BankImplementation Customer = new BankImplementation();
            ////Customer.getBalance();
            //Bank Customer = new BankImplementation();
            //Customer.credit(7722, 5000F);
            //Customer.Debit(7722, 500);
            



  //Abstraction Example
            //Car Newcar = new Car();
            //Newcar.Start();
            //Newcar.StartMusic();
            //Newcar.BrakingSystem();
            //Newcar.StopMusic();
            //Newcar.Stop();

   //polymorphism Example 
      // Method Overloading Example
            //Sum sum = new Sum();
            //   int result1 = sum.FindSum(20, 50);
            //   double result2 =  sum.FindSum(22.5, 28.5);
            //   double result3 = sum.FindSum(22.5, 58.4,72.85);

            //Console.WriteLine(result1 +" "+result2 +" "+ result3); 
     //Method Overriding Example
            Traingle  triangle = new Traingle();
            triangle.Area();
            Circle circle = new Circle();  
            circle.Area();
            Rectangle rect = new Rectangle();
            rect.Area();

    


        }
    }

}
