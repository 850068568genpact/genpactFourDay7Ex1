using System;
using ShapeAreaLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            string choice;
            do
            {
                Console.WriteLine("Choose Operation \n 1. Rectangle \n 2. Square \n 3. Circle \n 4. Triangle\n");

                Calculation calculation = new Calculation();

                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            double length2, breadth2;

                            Console.WriteLine("Enter Length: ");
                            length2 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Breadth: ");
                            breadth2 = double.Parse(Console.ReadLine());

                            area = calculation.RectangleAr(length2, breadth2);
                            Console.WriteLine("Area of Rectangle of length {0} cm and breadth {1} cm is {2} Sqcm", length2, breadth2, area);
                            break;
                        }
                    case 2:
                        {
                            double side2;

                            Console.WriteLine("Enter Side: ");
                            side2 = double.Parse(Console.ReadLine());

                            area = calculation.SquareAr(side2);
                            Console.WriteLine("Area of Square of side {0} cm is {1} Sqcm", side2, area);
                            break;
                        }
                    case 3:
                        {
                            double radius2;

                            Console.WriteLine("Enter Radius: ");
                            radius2 = double.Parse(Console.ReadLine());

                            area = calculation.CircleAr(radius2);
                            Console.WriteLine("Area of Circle of radius {0} cm is {1} Sqcm", radius2, area);
                            break;
                        }
                    case 4:
                        {
                            double base2, height2;

                            Console.WriteLine("Enter Base: ");
                            base2 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Height: ");
                            height2 = double.Parse(Console.ReadLine());

                            area = calculation.TriangleAr(base2, height2);
                            Console.WriteLine("Area of Triangle of base {0} cm and height {1} cm is {2} Sqcm", base2, height2, area);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Shape Choice!!!");
                            break;
                        }
                }
                Console.WriteLine("\nPress y to Continue");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
