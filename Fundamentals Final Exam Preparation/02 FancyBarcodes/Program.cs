using System;
using System.Text.RegularExpressions;

namespace _02_FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            string barcodePattern = @"^@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+$";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, barcodePattern);
                if (match.Success)
                {
                    string groupPattern = @"[0-9]";
                    var matches = Regex.Matches(match.Value, groupPattern);
                    if (matches.Count==0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        string productGroup = string.Concat(matches);
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
            
            
        }
    }
}
