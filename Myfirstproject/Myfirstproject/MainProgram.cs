using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


namespace Myfirstproject
{
    internal class MainProgram
    {
        public static void Main()
        {
            //try
            //{
            //    // Create an instance of the Factorial class
            //    Factorial factorial = new Factorial();

            //    // Prompt the user to enter a number
            //    Console.WriteLine("Enter a number to calculate its factorial:");
            //    int n = int.Parse(Console.ReadLine());

            //    // Calculate the factorial and display the result
            //    int result = factorial.Findfactorial(n);
            //    Console.WriteLine($"The factorial of {n} is: {result}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input! Please enter an integer.");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    Fibonacci fibonacci = new Fibonacci();

            //    Console.WriteLine("Enter limit :");
            //    int fib = int.Parse(Console.ReadLine());

            //    fibonacci.FindFibonacci(fib);


            //}
            //catch (ArgumentException e) { 
            // Console.WriteLine(e.Message);
            //}
            //try {
            //    PrimeNum prime = new PrimeNum();    
            //    Console.WriteLine("Enter Number :");
            //    int number = int.Parse(Console.ReadLine());
            //    if (prime.CheckPrimeNum(number))
            //    {
            //        Console.WriteLine("Number is prime!");
            //    }
            //    else Console.WriteLine("Number is not a prime!");

            //} catch (ArgumentException ex) { 

            //Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Console.WriteLine("Enter number of elements in Array:");
            //    int SizeofArray = int.Parse(Console.ReadLine());

            //    int[] arr2 = new int[SizeofArray];
            //    //Console.WriteLine($"Enter {SizeofArray} Element of Array");
            //    for (int i = 0; i < SizeofArray; i++)
            //    {
            //        Console.Write($"Enter element {i + 1}: ");
            //        arr2[i] = int.Parse(Console.ReadLine());
            //    }

            //    DescBubblesort descbubbleSort = new DescBubblesort();

            //    descbubbleSort.Sorter(arr2);
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        Console.Write(arr2[j] + " ");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Enter String :");
            //String str = Console.ReadLine();

            //ReverseString reverseString1 = new ReverseString();
            //reverseString1.ReversingString(str);
            //try
            //{
            //    Console.WriteLine("Enter num1 and num2:");
            //    double num1 = double.Parse(Console.ReadLine());
            //    double num2 = double.Parse(Console.ReadLine());


            //    Console.Write("Enter an operator (+, -, *, /): ");
            //    char op = char.Parse(Console.ReadLine());
            //    Calculator calc = new Calculator();
            //    double Result = calc.PerformOperation(num1, num2, op);
            //    Console.WriteLine(Result);
            //}
            //catch(ArithmeticException e) {
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception ex) { 
            //Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine("Enter the number of elements in Array:");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter {i + 1} Element:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            ////MaximumEle maximumEle = new MaximumEle();
            ////maximumEle.MaximumElement(arr);
            ////Console.WriteLine();

            //Secondmax secondmax = new Secondmax();
            //secondmax.SecondMaximumElement(arr);
            //Console.WriteLine();

            //Console.WriteLine("Enter String :");
            //String str = Console.ReadLine();
            //FrequencyofElements frequencyofElements = new FrequencyofElements();
            //Dictionary<Char, int> keyValuePairs = frequencyofElements.CalculateFrequencyofEle(str);
            //foreach (var Pair in keyValuePairs) { 
            //Console.WriteLine($" { Pair.Key} : {Pair.Value}");
            //}


            //Console.WriteLine("Enter a character :");
            //char ch = Char.Parse(Console.ReadLine());
            //ASCIIVal aSCIIVal = new ASCIIVal();
            //aSCIIVal.FindASCIIval(ch);


            //Console.WriteLine("Enter Shape");
            //String Shape = Console.ReadLine();

            //Console.WriteLine("enter side1 and side2:");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //Area area = new Area();
            //double result = area.FindArea(Shape,num1,num2);
            //Console.WriteLine(result);


            //Console.WriteLine("Enter a Year :");
            //int year = int.Parse(Console.ReadLine());
            //Leapyear leapyear = new Leapyear();
            //if(leapyear.CheckifLeap(year))
            //    Console.WriteLine("It's a Leap year!");
            //else Console.WriteLine("It's not a Leap year!");

            //Console.WriteLine("Enter the number of elements in Array:");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter {i + 1} Element:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //ReverseArray reverseArray = new ReverseArray();
            //reverseArray.ReversingArray(arr);
            //Console.Write("[");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write(arr[i]+" ");

            //}
            //Console.Write("]");


            //Console.WriteLine("Enter Limit:");
            //int limit = int.Parse(Console.ReadLine());  
            //PrimeuptoN primeuptoN = new PrimeuptoN();
            //primeuptoN.PrintPrime(limit);   
            //Console.WriteLine("Enter number :");
            //int num = int.Parse(Console.ReadLine());    
            //Armstrong armstrong = new Armstrong();
            //if (armstrong.isArmstrong(num))
            //{
            //    Console.WriteLine("Number is Armstrong!");
            //}
            //else { Console.WriteLine("Number is not Armstrong!"); }
            //try
            //{
            //    Console.WriteLine("Enter num1:");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter num2:");
            //    int num2 = int.Parse(Console.ReadLine());
            //    GCD gCD = new GCD();
            //    //int gcd = gCD.FindGCD(num1, num2);
            //    //Console.WriteLine(gcd);

            //    int lcm = gCD.FindLCM(num1, num2);
            //    Console.WriteLine(lcm);


            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            //DateTime now = DateTime.Now;
            //Console.WriteLine(DateTime.Now.ToString("f"));

            //int[] arr1 = {1, 3, 5, 7, 23};
            //int[] arr2 = {5, 6, 34, 56, 23};

            //MergeArray mergeArray = new MergeArray();
            //mergeArray.MergingArray(arr1, arr2);


            //Console.WriteLine("Enter Decimalnum:");
            //int Decimalnum = int.Parse(Console.ReadLine()); 
            //DecimaltoBinnary decimaltoBinnary = new DecimaltoBinnary();
            //String binnary = decimaltoBinnary.ConvertDectoBin(Decimalnum);
            //Console.WriteLine(binnary);
            //Console.WriteLine( );

            //int[] arr1 = { 1, 3, 5, 7, 23, 56 };
            //int[] arr2 = { 5, 6, 34, 56, 23 };

            //CommonEle commonEle = new CommonEle();
            //commonEle.FindCommonElements(arr1, arr2);


            //PerfectSquare perfectsquare = new PerfectSquare();
            //if (perfectsquare.CheckPerfectSquare(2.25))
            //{
            //    Console.WriteLine("Number is perfect Square!");
            //}
            //else { Console.WriteLine("Number is not a perfect Square!"); } 

            LinkedList linkedList = new LinkedList();
            linkedList.Insert(4);
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(8);

            linkedList.display();

            Console.WriteLine();

            if (linkedList.Search(10))
            {
                Console.WriteLine("10 is present!");
            }
            else { Console.WriteLine("10 is present!"); }

            linkedList.Delete(5);
            linkedList.Delete(5);

            linkedList.display();

        }
    }
}
