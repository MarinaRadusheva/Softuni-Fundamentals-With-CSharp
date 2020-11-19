using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            // {Serial Number} {Item Name} {Item Quantity} {itemPrice}
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (input!="end")
            {
                string[] nextBoxElements = input.Split();
                string serialNum = nextBoxElements[0];
                string itemName = nextBoxElements[1];
                int itemsCount = int.Parse(nextBoxElements[2]);
                decimal itemPrice = decimal.Parse(nextBoxElements[3]);
                Item nextItem = new Item { ItemName = itemName, ItemPrice = itemPrice };
                Box nextBox = new Box { Item = nextItem, BoxPrice = nextItem.ItemPrice * itemsCount, ItemlNum = serialNum, ItemQtty = itemsCount };
                boxes.Add(nextBox);
                input = Console.ReadLine();
            }
            List<Box> sorted = boxes.OrderByDescending(x=>x.BoxPrice).ToList();
            
            foreach (var box in sorted)
            {
                Console.WriteLine($"{box.ItemlNum}\n-- {box.Item.ItemName} - ${box.Item.ItemPrice:f2}: {box.ItemQtty}\n-- ${box.BoxPrice:f2}");
                
            }
        }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
    }
    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string ItemlNum { get; set; }
        public Item Item { get; set; }
        public int ItemQtty { get; set; }
        public decimal BoxPrice { get; set; }

        

    }
}
