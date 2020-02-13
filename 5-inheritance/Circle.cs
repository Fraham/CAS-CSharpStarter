using System;

namespace _5_inheritance
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public override double Perimeter()
        {
            return Math.Round(Math.PI * 2 * Radius, 2);
        }

        // Define a circumference, since it's the more familiar term.
        public double Circumference()
        {
            return Perimeter();
        }

        public double Radius { get; }

        public double Diameter()
        {
            return Radius * 2;
        }
    }
}
