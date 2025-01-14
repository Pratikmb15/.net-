using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class main : A
    {
        static void Main(string[] args)
        {
            //Friends friends = new Friends();
            //friends.friend();

            //Console.WriteLine("Enter Two numbers:");
            //float num1 = float.Parse(Console.ReadLine());
            //float num2 = float.Parse(Console.ReadLine());
            //SquareSumDiff obj1 = new SquareSumDiff();
            //obj1.SquareSumandDiff(num1,num2);

            //Console.WriteLine("Enter your Favourite Place Name:");
            //String name = Console.ReadLine();   
            //Uppandlowcase uppandlowcase = new Uppandlowcase();
            //uppandlowcase.Upperandlowercase(name);

            //Console.WriteLine("Enter number as String");
            //String number = Console.ReadLine(); 
            //NumasString object1 = new NumasString();
            //object1.NumberasString(number);


            //Console.WriteLine("Enter Your FullName");
            //String Fullname = Console.ReadLine(); 
            //SplitName splitName = new SplitName();
            //splitName.splitname(Fullname);

            //RandomnumsAvg avg = new RandomnumsAvg();    
            //avg.AvgofRandomNums();

            //PerimeterofCircle circle = new PerimeterofCircle();
            //circle.FindPerimeterofCircle(10.50f);

            // Nextdate nextdate = new Nextdate();

            //Console.WriteLine("Enter day:");
            //int day = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter month:");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter year:");
            //int year = int.Parse(Console.ReadLine());

            //nextdate.Findnextday(day, month, year);

            //Executiontime executiontime = new Executiontime();
            //    executiontime.FindExecutionTime();


            //Specialnum specialnum = new Specialnum();
            //    specialnum.FindSpecialnum();

            //DataTypes data = new DataTypes();
            //    data.datatype();

            //ConditionalStatements obj11 = new ConditionalStatements();
            // obj11.CheckNatural();

            //char ch = '-';
            //double result = obj11.calculator(ch, 5, 7);
            //double r = Math.Round(result,2);
            //Console.WriteLine(r);

            //   obj11.CheckName();

            //CarModel car = new CarModel();
            //String brand = car.getBrand();//Accesing Private data using getter 
            //Console.WriteLine(brand);

            //car.Carmodel("Innova", "Toyota");
            //Console.WriteLine(car.brand);
            //Console.WriteLine(car.model);

            //Car car1 = new Car();
            //int sales=  car1.Carsales();
            //Console.WriteLine(sales);

            //main obj32 = new main();
            //Console.WriteLine(obj32.x + " " + obj32.y);//Direct access to protected data by derived classes.

            //Generic Custom Arraylist
            //GenericCustomArraylist<int> customArrayList = new GenericCustomArraylist<int>();
            //customArrayList.add(5);
            //customArrayList.add(18);
            //customArrayList.add(23);
            //customArrayList.add(11);
            //customArrayList.add(24);


            //customArrayList.Display();
            //customArrayList.Delete();
            //customArrayList.Display();

            //customArrayList.set(2, 35);
            //customArrayList.Display();

            MyGenericClass<int> GenObj = new MyGenericClass<int>(20);
            GenObj.GenericMethod(30);

            







        }
    }
}
