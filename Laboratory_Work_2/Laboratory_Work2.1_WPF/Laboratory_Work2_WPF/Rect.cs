using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work2_WPF
{
    class Rect : Shape
    {
        private double sideA;
        private double sideB;

        public Rect()
        {
            sideA = 0.0d;
            sideB = 0.0d;

            name = "Прямоугольник";

        }

        public Rect(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double Perimetr()
        {
            perimeter = 2*sideB + 2*sideA;

            return perimeter;
        }

        public double Area()
        {
            area = sideA * sideB;
            return area;
        }

    }
}
