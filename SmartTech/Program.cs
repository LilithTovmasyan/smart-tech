using System;

namespace SmartTech
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Samsung A10 = new Samsung("A10", 350000, 15, "Android", "Samsung Exynos", 8, 15, 64, "9.0", false);
            A10.Print();

            IPhone Iphone11 = new IPhone("Iphone11", 470000, 15, "iOS 13", "proc", 8, 150, 128, "13", true, true, true);
            Iphone11.Print();

            Console.ReadKey();
        }
    }
}