using System;

namespace Laboratory_Work_1
{
    class Program
    {
        static CupOfCoffee cupCoffe;
        static CupOfTea cupTea;
        private static string milk;
        private static string suggar;
        private static string typeGlass;
        private static string volume;
         
        struct Oders
        {
            public string itemname; //наименование
            public int unitCount;   //число единиц
            public double unitCost; //стоимость одной единицы

            public void Input()
            {
                Console.WriteLine(unitCount+ " " + itemname + " " + unitCost  + "p.");
            }

        }



        static void Main(string[] args)
        {
            Start();
        }


        private static void Start()
        {
            CupOfCoffee coffe = new CupOfCoffee();
            CupOfTea tea = new CupOfTea();

            Console.WriteLine("Выберите напиток: кофе<1> или чай <2>: ");
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            string teaorCoffe = Console.ReadLine();
            Console.ResetColor(); // сбрасываем в стандартный

            if (teaorCoffe == "1")
            {
                InterfaceInformation("coffe");
                ProcessCup(coffe);
                
            }
            else if (teaorCoffe == "2")
            {
                InterfaceInformation("tea");
                ProcessCup(tea);

            }

            
        }

        private static void InterfaceInformation(string teaOrcoffe)
        {
            if(teaOrcoffe == "coffe")
            {
                Console.WriteLine("Тип зерен: Арабика или Робуста <по умолч. Aрабика>");
            }
            if (teaOrcoffe == "tea")
            {
                Console.WriteLine("Тип Чая: Ройбуш или Сенча <по умолч. Ройбуш>");
            }
            Console.WriteLine("Сахар: 0....5  <по умолч. 3>");

            Console.WriteLine("Молоко: 0....10  <по умолч. 3>");

            Console.WriteLine("Тип стакана: Пластик или Стекло  <по умолч. Пластик>");

            Console.WriteLine("Объем стакана: 0,2 или 0,3  <по умолч. 0,2>");

        }


        private static void ProcessCup(HotDrink hotDrink)
        {
            if (hotDrink is CupOfCoffee)
            {
                cupCoffe = hotDrink as CupOfCoffee;

                Console.WriteLine(" Тип Зерен: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                string grainType = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (grainType != "Арабика" && grainType != "Робуста")
                    grainType = "Арабика";

                cupCoffe.BeanType = grainType;

                Console.WriteLine(" Молоко: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                milk = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (milk != "0" && milk != "1" && milk != "2" && milk != "3" && milk != "4" && milk != "5" && milk != "6" && milk != "7" && milk != "8" && milk != "9" && milk != "10" )
                    milk = "3";

                cupCoffe.AddMilk(milk);


                Console.WriteLine(" Сахар: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                suggar = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (suggar != "0" && suggar != "1" && suggar != "2" && suggar != "3" && suggar != "4" && suggar != "5")
                    suggar = "3";
                cupCoffe.AddSugar(suggar);


                Console.WriteLine(" Тип стакана: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                typeGlass = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (typeGlass != "Пластик" && typeGlass != "Стекло")
                    typeGlass = "Пластик";
                cupCoffe.Type = typeGlass;


                Console.WriteLine(" Объем: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                volume = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (volume != "0,3" && volume != "0,2")
                    volume = "0,2";
                cupCoffe.Capacity = volume;


                Console.WriteLine("------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" В коффе добавлен сахар: " + cupCoffe.Sugar);
                Console.WriteLine(" В коффе добавлено молоко: " + cupCoffe.Milk);
                Console.WriteLine(" Получите коффе: " + cupCoffe.BeanType);
                Console.WriteLine(" Коффе в стакане: " + cupCoffe.Type + " Объемом: " + cupCoffe.Capacity);

                cupCoffe.Wash(typeGlass);
                cupCoffe.Refill(volume);
                Console.ResetColor();

                Oders Coffe;

                Coffe.itemname = "Коффе " + grainType;
                Coffe.unitCost = 100;
                Coffe.unitCount = 1;
                Coffe.Input();

            }
            else
            if (hotDrink is CupOfTea)
            {
                cupTea = hotDrink as CupOfTea;

                Console.WriteLine(" Тип Чая: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                string varietyTea = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (varietyTea != "Ройбуш" && varietyTea != "Сенча")
                    varietyTea = "Ройбуш";
                cupTea.LeftType = varietyTea;



                Console.WriteLine(" Молоко: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                milk = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (milk != "0" && milk != "1" && milk != "2" && milk != "3" && milk != "4" && milk != "5" && milk != "6" && milk != "7" && milk != "8" && milk != "9" && milk != "10")
                    milk = "3";
                cupTea.AddMilk(milk);




                Console.WriteLine(" Сахар: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                suggar = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (suggar != "0" && suggar != "1" && suggar != "2" && suggar != "3" && suggar != "4" && suggar != "5")
                    suggar = "3";
                cupTea.AddSugar(suggar);



                Console.WriteLine(" Тип стакана: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                typeGlass = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (typeGlass != "Пластик" && typeGlass != "Стекло")
                    typeGlass = "Пластик";
                cupTea.Type = typeGlass;

                Console.WriteLine(" Объем: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                volume = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный
                if (volume != "0,3" && volume != "0,2")
                    volume = "0,2";
                cupTea.Capacity = volume.ToString();

                Console.WriteLine("------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" В чай добавлен сахар: " + cupTea.Sugar);
                Console.WriteLine(" В чай добавлено молоко: " + cupTea.Milk);
                Console.WriteLine(" Получите чай: " + cupTea.LeftType);
                Console.WriteLine(" Чай в стакане: " + cupTea.Type + " Объемом: " + cupTea.Capacity);
                Console.ResetColor();

                cupTea.Wash(typeGlass);
                cupTea.Refill(volume);

                Oders Tea;

                Tea.itemname = "Коффе " + varietyTea;
                Tea.unitCost = 50;
                Tea.unitCount = 1;
                Tea.Input();
            }
        }


    }
}
