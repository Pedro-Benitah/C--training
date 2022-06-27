using System;
using System.Collections.Generic;
using AreaCalculator.Entities;
using AreaCalculator.Entities.Enums;
using System.Globalization;

namespace AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                switch (ch)
                {
                    case ('r'):
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Heigth: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Rectangle(width, height, color));
                        break;
                    case ('c'):
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Circle(radius, color));
                        break;
                }
                Console.WriteLine("\nSHAPE AREAS:");
                foreach(Shape shape in list)
                {
                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
