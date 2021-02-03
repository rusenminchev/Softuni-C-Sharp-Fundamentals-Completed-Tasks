using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Threading;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            string index1 = "";
            string index2 = "";

            while (command != "end")
            {
                string[] commandElements = command.Split();

                string command1 = commandElements[0];
                if (command1 == "swap" || command1 == "multiply")
                {
                   index1 = commandElements[1];
                   index2 = commandElements[2];
                }
                

                if (command1 == "swap")
                {
                    int temp = numbers[int.Parse(index1)];
                    numbers[int.Parse(index1)] = numbers[int.Parse(index2)];
                    numbers[int.Parse(index2)] = temp;
                }
                else if (command1 == "multiply")
                {
                    numbers[int.Parse(index1)] = numbers[int.Parse(index1)] * numbers[int.Parse(index2)];
                }
                else if (command1 == "decrease")
                {

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
