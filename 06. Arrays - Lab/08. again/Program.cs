﻿using System;
using System.Linq;

namespace _08._again
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Length != 1)
            {

                int[] condences = new int[numbers.Length - 1];

                for (int i = 0; i < condences.Length; i++)
                {
                    condences[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condences;

            }

            Console.WriteLine(numbers[0]);

        }
    }
}
