using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            

            double averageValue = 0;
            int numbersSum = 0;
            int greatestNums = int.MinValue;

            List<int> topIntagers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbersSum += numbers[i];
            }

            averageValue = numbersSum * 1.0 / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageValue)
                {
                    greatestNums = numbers[i];
                    topIntagers.Add(greatestNums);
                }
            }

            List<int> sorted = new List<int>();
            sorted = topIntagers.OrderByDescending(x => x).ToList();

            List<int> top5 = new List<int>();

            if (numbers.Count == 1)
            {
                Console.WriteLine("No");
            }
            else if (sorted.Count > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    top5.Add(sorted[i]);
                }
                Console.WriteLine(String.Join(" ", top5));
            }
            else
            {
                Console.WriteLine(String.Join(" ", sorted));
            }
        }
    }
}
