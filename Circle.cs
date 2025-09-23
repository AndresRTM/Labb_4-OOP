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

        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public double  GetDiameter()
        {
            return Radius * 2;
        }

        public double GetVolume()
        {
            return (4/3) * Math.PI * Math.Pow(Radius, 3);
        }

        public double Radius { get; set; }

        }
    }

