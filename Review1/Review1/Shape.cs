using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Shape
    {
        public void findArea(double para1, String Shape)
        {
            Double Area = double.MinValue;
            
            switch (Shape)
            {

                case "Square":
                    Area = para1 * para1;
                    Console.WriteLine($"Area of Square is {Area}");
                    break;
                case "Circle":
                    Area = 3.14 * para1 * para1;
                    Console.WriteLine($"Area of Circle is {Area}");
                    break;
                default:
                    Console.WriteLine("Enter Correct Shape");
                    break;
            }
        }
        public void findArea(double para1, double para2, String Shape)
        {
            Double Area = double.MinValue;
            switch (Shape)
            {

                case "Rectangle":
                    Area = para1 * para2;
                    Console.WriteLine($"Area of Rectangle is {Area}");
                    break;
                case "Triangle":
                    Area = 0.5 * para1 * para2;
                    Console.WriteLine($"Area of Triangle is {Area}");
                    break;
                default:
                    Console.WriteLine("Enter Correct Shape");
                    break;
            }

        }

    }
}



    

