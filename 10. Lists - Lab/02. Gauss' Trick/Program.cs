using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numbersSums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count / 2)
                {
                    numbers[i] += numbers[numbers.Count - 1 - i];
                    numbersSums.Add(numbers[i]);
                }
            }
            if (numbers.Count % 2 == 1)
            {
                numbersSums.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", numbersSums));
        }
    }
}
