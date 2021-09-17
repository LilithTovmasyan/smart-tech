using System;

namespace SmartTech
{
    public class SmartDevice
    {
        public string Name;
        public double Price;

        public SmartDevice(string name, Double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void Print()
        {
            Console.WriteLine("SmartDevice description:");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Price: {this.Price}");
        }
    }
}