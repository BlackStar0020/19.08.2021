using System;

namespace _111
{
    class Program
    {
         class Rectangle
        {
            public double side1, side2;

            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }

            public double AreaCalculator()
            {
                return side1 * side2;
            }
            public double PerimeterCalculator()
            {
                return 2 * (side1 + side2);
            }
            public double Area
            {
                get { return AreaCalculator(); }
            }

            public double Perimeter
            {
                get { return PerimeterCalculator(); }
            }
        }
        static void Main(string[] args)
        {
            var p1 = Convert.ToDouble(Console.ReadLine());
            var p2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(p1, p2);
            Console.WriteLine($"Ploshad: {rectangle.Area},Parametr: {rectangle.Perimeter}");
        }
    }
}
