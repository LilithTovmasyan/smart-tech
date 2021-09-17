using System;

namespace SmartTech
{
    public class IPhone : SmartPhone
    {
        public string IosVersion;
        public bool IsUSVersion;
        public bool HasESim;
        public bool HasFaceId;

        public IPhone(string name,
            double price,
            int batteryLife,
            string operatingSystem,
            string processor,
            int ram,
            int screenSize,
            int storage,
            string iosVersion,
            bool isUSVersion,
            bool hasESim,
            bool hasFaceId)
            : base(name, price, batteryLife, operatingSystem, processor, ram, screenSize, storage)
        {
            this.IosVersion = iosVersion;
            this.IsUSVersion = isUSVersion;
            this.HasESim = hasESim;
            this.HasFaceId = hasFaceId;
        }

        public new void Print()
        {
            base.Print();

            Console.WriteLine("Iphone description:");

            Console.WriteLine($"IosVersion: {this.IosVersion}");
            if (this.IsUSVersion)
            {
                Console.WriteLine($"US version");
            }
            else
            {
                Console.WriteLine($"Not US version");
            }

            if (this.HasESim)
            {
                Console.WriteLine($"esim supported.");
            }
            else
            {
                Console.WriteLine($"Do not support esim.");
            }

            if (this.HasFaceId)
            {
                Console.WriteLine($"FaceId supported.");
            }
            else
            {
                Console.WriteLine($"Do not support FaceId.");
            }
        }
    }
}