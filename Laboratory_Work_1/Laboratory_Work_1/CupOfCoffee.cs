using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Work_1
{
    class CupOfCoffee : HotDrink, ICup
    {

        public string BeanType { get; set; }

        public override int Sugar
        {
            get
            {
                return sugar;
            }
            set
            {
                if (value >= 0)
                {
                    sugar = value;
                }
                else
                    throw new Exception("Сахар не может быть отрицательным");
            }
        }

        public override int Milk
        {
            get
            {
                return milk;
            }
            set
            {
                if (value >= 0)
                {
                    milk = value;
                }
                else
                    throw new Exception("молоко не может быть отрицательным");
            }
        }

        public string Type { get; set; }

        public string Capacity { get; set; }

        public override void AddMilk(string milk)
        {
            Milk = Convert.ToInt32(milk);
        }

        public override void AddSugar(string suggar)
        {
            Sugar = Convert.ToInt32(suggar);
        }

        public void Refill(string capacity)
        {
            Console.WriteLine(" Повторить коффе объемом " + capacity);
        }

        public override void stringDrink()
        {

        }

        public void Wash(string type)
        {
            Console.WriteLine(" Вымыть " + type + " чашку с коффе");
        }



    }
}
