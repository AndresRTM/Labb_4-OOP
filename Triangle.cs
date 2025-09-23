using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_OOP
{
    internal class Triangle
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

    }
}
