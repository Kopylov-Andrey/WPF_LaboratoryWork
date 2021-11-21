using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work2_WPF
{
    class Circle : Shape
    {
        

        private const double PI = 3.1415926535897931d;

        private double radius;

        public Circle()
        {
            name = "окружность";
            area = 0.0d;
            perimeter = 0.0d;
        }


        public Circle(double radius)
        {
            this.radius = radius;
        }


        public double Perimetr()
        {
            perimeter = 2 * PI * radius;

            return perimeter;
        }

        public double Area()
        {
            area = PI * radius * radius;
            return area;
        }
            

    }
}
