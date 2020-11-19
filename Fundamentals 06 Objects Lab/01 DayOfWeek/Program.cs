using System;
using System.Globalization;

namespace _01_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(stringDate, "dd-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
                                
        }
    }
}
