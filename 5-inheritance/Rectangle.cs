using System;

namespace _5_inheritance
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; }

        public double Width { get; }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }

        public virtual bool IsSquare()
        {
            return Length == Width;
        }

        public double Diagonal()
        {
            return Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);
        }
    }
}
