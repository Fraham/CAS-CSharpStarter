using System;

namespace _5_inheritance
{
    public class Square : Rectangle
    {
        public Square(double length) : base (length, length)
        {

        }

        public override bool IsSquare()
        {
            return true;
        }

        // public double Side { get; }

        // public override double Area() {
        //     return Math.Pow(Side, 2);
        // }

        // public override double Perimeter()
        // {
        //     return Side * 4;
        // }

        // public double Diagonal()
        // {
        //     return Math.Round(Math.Sqrt(2) * Side, 2);
        // }
    }
}
