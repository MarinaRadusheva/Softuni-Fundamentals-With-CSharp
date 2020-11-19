using System;
using System.Text.RegularExpressions;

namespace _03_BarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            //% InvalidName %< Croissant >| 2 | 10.3$
            //% Peter %< Gum > 1.3$
            //% Maria %< Cola >| 1 | 2.4
            //% Valid %< Valid > valid | 10 | valid20$
            //end of shift
            string input = Console.ReadLine();
            string customerPattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>[0-9]+)\|[^|$%.0-9]*(?<price>[0-9]+[.]?[0-9]*)\$";
            double income = 0;
            
            while (input!="end of shift")
            {
                Match newEntry = Regex.Match(input, customerPattern);
                if (newEntry.Success)
                {
                    string customerName = newEntry.Groups["customer"].Value;
                    string product = newEntry.Groups["product"].Value;
                    double totalPrice = double.Parse(newEntry.Groups["price"].Value) * int.Parse(newEntry.Groups["count"].Value);
                    income += totalPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                }
                
                input = Console.ReadLine();
            }
            //customer, product, count and a price
            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
