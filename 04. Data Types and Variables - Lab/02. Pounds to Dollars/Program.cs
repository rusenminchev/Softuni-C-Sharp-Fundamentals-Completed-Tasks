using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int units = int.Parse(Console.ReadLine());

            double gbpToUsd = units * 1.31;

            Console.WriteLine($"{gbpToUsd:f3}");
        }
    }
}
