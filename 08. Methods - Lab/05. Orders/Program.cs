using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    CalculatesTheTotalPrice(quantity, 1.50);
                    break;

                case "water":
                    CalculatesTheTotalPrice(quantity, 1.00);
                    break;

                case "coke":
                    CalculatesTheTotalPrice(quantity, 1.40);
                    break;

                case "snacks":
                    CalculatesTheTotalPrice(quantity, 2.00);
                    break;
            }
        }

        static void CalculatesTheTotalPrice(int quantity, double price)
        {
            Console.WriteLine($"{quantity* price:f2}");
        }
    }
}
