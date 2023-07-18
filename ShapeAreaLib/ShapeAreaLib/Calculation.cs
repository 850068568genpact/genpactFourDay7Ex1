using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
        public class Calculation
        {
            public double RectangleAr(double length, double breadth)
            {
                double area = (length * breadth);
                return area;
            }
            public double SquareAr(double side)
            {
                double area = (side * side);
                return area;
            }
            public double CircleAr(double radius)
            {
                double area = ((22/7) * radius * radius);
                return area;
            }
            public double TriangleAr(double base1, double height)
            {
                double area =(0.5 * base1 * height);
                return area;
            }
        }
    }

