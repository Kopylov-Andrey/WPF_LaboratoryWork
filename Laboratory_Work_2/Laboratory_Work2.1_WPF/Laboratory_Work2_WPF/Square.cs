using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work2_WPF
{
    class Square : Rect
    {
        public Square (double sideA, double sideB) : base(sideA, sideB)
        {
            name = "Квадрат";
        }
}
}
