using System;


namespace Labb_4_OOP
{
    internal class Circle
    {
        public Circle(double radius) 
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Radius * 2 * Math.PI;
        }

        public double Radius { get; set; }

        }
    }
}
