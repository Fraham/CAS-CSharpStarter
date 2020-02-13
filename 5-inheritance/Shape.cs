using System;

namespace _5_inheritance
{
    public abstract class Shape
    {
        public abstract double Area();

        public abstract double Perimeter();

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
