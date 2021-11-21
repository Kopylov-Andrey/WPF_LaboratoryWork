using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work2_WPF
{
    class Shape
    {
        protected double area;

        protected double perimeter;

        protected string name;



        public Shape()
        {
            area = 0.0d;

            perimeter = 0.0d;

            name = "Без названия";
        }


        void show()
        {
            Console.WriteLine("Площадь: " + area);
            Console.WriteLine("\nПериметр: " + perimeter);
            Console.WriteLine("\nНазвание фигуры: " + name);
        }

    }
}
