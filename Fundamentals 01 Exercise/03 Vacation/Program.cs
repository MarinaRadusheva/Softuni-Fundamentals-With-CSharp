using System;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePP = 0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePP = 8.45;
                            break;
                        case "Saturday":
                            pricePP = 9.80;
                            break;
                        case "Sunday":
                            pricePP = 10.46;
                            break;
                    }
                    if (people>=30)
                    { pricePP = pricePP * 0.85; }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePP = 10.90;
                            break;
                        case "Saturday":
                            pricePP = 15.60;
                            break;
                        case "Sunday":
                            pricePP = 16;
                            break;
                    }
                    if (people>=100)
                    {
                        people -= 10;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePP = 15;
                            break;
                        case "Saturday":
                            pricePP = 20;
                            break;
                        case "Sunday":
                            pricePP = 22.50;
                            break;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        pricePP = pricePP * 0.95;
                    }
                    break;

            }
            double totalPrice = people*pricePP;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
