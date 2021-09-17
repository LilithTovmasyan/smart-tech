using System;

namespace SmartTech
{
    public class Samsung : SmartPhone
    {
        public string AndroidVersion;
        public bool HasPen;

        public Samsung(string name,
            double price,
            int batteryLife,
            string operatingSystem,
            string processor,
            int ram,
            int screenSize,
            int storage,
            string androidVersion,
            bool hasPen)
            : base(name, price, batteryLife, operatingSystem, processor, ram, screenSize, storage)
        {
            this.AndroidVersion = androidVersion;
            this.HasPen = hasPen;
        }

        public new void Print()
        {
            base.Print();

            Console.WriteLine("Samsung description:");

            Console.WriteLine($"AndroidVersion: {this.AndroidVersion}");

            if (this.HasPen)
            {
                Console.WriteLine($"Pen supported");
            }
            else
            {
                Console.WriteLine($"Do not support any pan");
            }
        }
    }
}