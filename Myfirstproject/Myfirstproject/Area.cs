using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class Area
    {
        public double FindArea(string shape, double side1, double side2)
        {
            switch (shape.ToLower()) 
            {
                case "square":
                    if (side1 != side2)
                        throw new ArgumentException("For a square, both sides must be equal.");
                    return side1 * side1;

                case "rectangle":
                    return side1 * side2;

                case "triangle":
                    return 0.5 * side1 * side2;

                default:
                    throw new ArgumentException("Unsupported shape. Please use 'square', 'rectangle', or 'triangle'.");
            }
        }
    }

}
