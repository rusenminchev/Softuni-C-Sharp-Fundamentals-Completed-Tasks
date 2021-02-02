using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingSpice = int.Parse(Console.ReadLine());

            int total = 0;
            int daysCount = 0;

            if (startingSpice >= 100)
            {
                while (startingSpice >= 100)
                {
                    daysCount++;
                    total += startingSpice;
                    startingSpice -= 10;
                    total -= 26;
                }

                total -= 26;
                Console.WriteLine(daysCount);
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(total);
            }
        }
    }
}
