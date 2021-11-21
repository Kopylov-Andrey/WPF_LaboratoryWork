using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Work_1
{
    abstract class HotDrink
    {
        protected int sugar;
        protected int milk;

        public abstract int Sugar { get; set; }


        public abstract int Milk { get; set; }


        public abstract void stringDrink();

        public abstract void AddMilk(string milk); 

        public abstract void AddSugar(string suggar);
    }
}
