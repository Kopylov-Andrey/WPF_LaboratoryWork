using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Work_1
{
    interface ICup
    {
        string Type { get; set; }

        string Capacity { get; set; }


        void Refill(string c);

        void Wash(string d);

    }
}
