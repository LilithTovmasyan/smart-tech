using System;

namespace SmartTech
{
    public class SmartPhone : SmartDevice
    {
        public int BatteryLife;
        public string OperatingSystem;
        public string Processor;
        public int Ram;
        public int ScreenSize;
        public int Storage;

        public SmartPhone(string name,
                    double price,
                    int batteryLife,
                    string operatingSystem,
                    string processor,
                    int ram,
                    int screenSize,
                    int storage)
            : base(name, price)
        {
            this.Name = name;
            this.BatteryLife = batteryLife;
            this.OperatingSystem = operatingSystem;
            this.Processor = processor;
            this.Ram = ram;
            this.ScreenSize = screenSize;
            this.Storage = storage;
        }

        public new void Print()
        {
            base.Print();

            Console.WriteLine("SmartPhone description:");

            Console.WriteLine($"BatteryLife: {this.BatteryLife}");
            Console.WriteLine($"OperatingSystem: {this.OperatingSystem}");
            Console.WriteLine($"Processor: {this.Processor}");
            Console.WriteLine($"Ram: {this.Ram}");
            Console.WriteLine($"ScreenSize: {this.ScreenSize}");
            Console.WriteLine($"Storage: {this.Storage}");
        }
    }
}