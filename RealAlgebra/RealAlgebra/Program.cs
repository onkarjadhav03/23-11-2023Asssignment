using ShapeAreaLib;
using System;
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
            Recatangle rect=new Recatangle();
            Circle circle=new Circle();
            Square square=new Square();
            Triangle tri=new Triangle();

            Console.WriteLine("Enter the name of shape to find its area");
            Console.WriteLine("1.Rectangle\n2.Circle\n3.square\n4.Triangle");
            Console.WriteLine("Enter your choice");
            int ch=int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine("Enter length");
                double length = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Breadth");
                double breadth = Double.Parse(Console.ReadLine());
                Console.WriteLine("Area of rectangle:" + rect.Area(length, breadth));
            }
            else if (ch == 2)
            {
                Console.WriteLine("Enter radius");
                double radius=Double.Parse(Console.ReadLine());
                Console.WriteLine("Area of Circle:" + circle.Area(radius));
            }
            else if (ch == 3)
            {
                Console.WriteLine("Enter side of square");
                double side = Double.Parse(Console.ReadLine());
                Console.WriteLine("Area of Square:" + square.Area(side));
            }
            else if (ch == 4)
            {
                Console.WriteLine("Enter Base");
                double breadth = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height");
                double height = Double.Parse(Console.ReadLine());
                Console.WriteLine("Area of Triangle:" + tri.Area(breadth, height));
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }
        }
    }
}
