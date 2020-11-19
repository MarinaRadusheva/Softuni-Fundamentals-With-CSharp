using System;
using System.Collections.Generic;

namespace _04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, Product>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="buy")
                {
                    break;
                }
                else
                {
                    string[] splitInput = input.Split();
                    string name = splitInput[0];
                    double price = double.Parse(splitInput[1]);
                    int quantity = int.Parse(splitInput[2]);
                    Product nextProduct = new Product(name, price, quantity);
                    if (!products.ContainsKey(name))
                    {
                        products.Add(name, nextProduct);
                    }
                    else
                    {
                        products[name].Price = price;
                        products[name].Quantity += quantity;
                    }
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity:F2}");
            }
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
