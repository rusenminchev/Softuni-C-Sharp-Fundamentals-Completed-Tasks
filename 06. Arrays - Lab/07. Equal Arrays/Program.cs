using System;
using System.Linq;
using System.Security.Cryptography;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int diffIndex = 0;
            int sum = 0;
            bool isDiff = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];
                }
                else if (arr1[i] != arr2[i])
                {
                    isDiff = true;
                    diffIndex = i;
                    break;
                }
            }

            if (isDiff == true)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
                
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
