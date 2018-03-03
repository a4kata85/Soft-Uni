using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.GeometryCalcolator
{
    class StartUp
    {
        static void Main()
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetTriangleArea(side, height));
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetSquareArea(side));
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetRectangleArea(sideA, sideB));
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetCircle(radius));
            }
        }
        public static double GetTriangleArea(double a, double h)
        {
            double area = (a * h) / 2.00;
            return area;
        }
        public static double GetSquareArea(double a)
        {
            double area = a * a;
            return area;
        }
        public static double GetRectangleArea(double a, double b)
        {
            double area = a * b;
            return area;
        }
        public static double GetCircle(double r)
        {
            double area = Math.PI * r*r;
            return area;
        }
    }
}
