using System;

namespace _5_inheritance
{
    class Program
    {
        public static void Main()
        {
            Shape[] shapes = {
                new Rectangle(10, 12),
                new Square(5),
                new Circle(3)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape}: area: {shape.Area()}; perimeter: {shape.Perimeter()}");

                var rect = shape as Rectangle;
                if (rect != null)
                {
                    Console.WriteLine($"   Is Square: {rect.IsSquare()}; Diagonal: {rect.Diagonal()}");
                    continue;
                }

                var cr = shape as Circle;
                if (cr != null)
                {
                    Console.WriteLine($"   Diameter: {cr.Diameter()}");
                    continue;
                }
            }
        }
    }
}
