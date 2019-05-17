using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFigure = Console.ReadLine();
            double area = 0.0;

            if (typeFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (typeFigure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (typeFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (typeFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double high = double.Parse(Console.ReadLine());
                area = (high * side) / 2;
            }

            Console.WriteLine($"{area:f3}");
        }
    }
}
