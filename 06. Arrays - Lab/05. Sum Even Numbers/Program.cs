using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];

            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);

                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}
