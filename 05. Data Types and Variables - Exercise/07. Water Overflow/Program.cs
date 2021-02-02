using System;
using System.Security.Cryptography;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfPouring = byte.Parse(Console.ReadLine());
            
            short sumOfLiters = 0;

            for (int i = 1; i <= numberOfPouring; i++)
            {
                short litters = short.Parse(Console.ReadLine());

                if (sumOfLiters + litters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumOfLiters += litters;
                } 
            }
            Console.WriteLine(sumOfLiters);
        }
    }
}
