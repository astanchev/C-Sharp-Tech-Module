using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            this.Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double PriceforBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxList = new List<Box>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                string[] input = inputLine.Split();
                string serialNumber = input[0];
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);
                double boxPrice = itemQuantity * itemPrice;
                Box newBox = new Box()
                {
                    SerialNumber = serialNumber,
                    Item =
                    {
                        Name = itemName,
                        Price = itemPrice
                    },
                    ItemQuantity = itemQuantity,
                    PriceforBox = boxPrice
                };
                boxList.Add(newBox);
            }
            List<Box> sortedBoxes = boxList.OrderBy(box => box.PriceforBox).Reverse().ToList();
            
            PrintBoxes(sortedBoxes);
        }

       

        private static void PrintBoxes(List<Box> sortedBoxes)
        {
            for (int i = 0; i < sortedBoxes.Count; i++)
            {
                Box element = sortedBoxes[i];
                Console.WriteLine($"{element.SerialNumber}");
                Console.WriteLine($"-- {element.Item.Name} - " +
                    $"${element.Item.Price:f2}: {element.ItemQuantity}");
                Console.WriteLine($"-- ${element.PriceforBox:f2}");
            }
        }
    }
}
