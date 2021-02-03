using System;
using System.Data;
using System.Linq;

namespace _10._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                string action = elements[0];

                if (action == "exchange")
                {
                    int commandIndex = int.Parse(elements[1]);
                    if (commandIndex >= 0 && commandIndex <= numbers.Length - 1)
                    {
                        int secondArrLength = numbers.Length - commandIndex;

                        int[] arr1 = new int[commandIndex];
                        int[] arr2 = new int[secondArrLength];
                        int arr2StartIndex = 0;

                        for (int i = 0; i < commandIndex; i++)
                        {
                            arr1[i] = numbers[i];
                        }
                        for (int i = commandIndex; i < numbers.Length; i++)
                        {

                            arr2[arr2StartIndex] = numbers[i];
                            arr2StartIndex++;

                        }
                        Console.Write(string.Join(" ", arr2));
                        Console.Write(' ');
                        Console.Write(string.Join(" ", arr1));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                }

            }

        }
    }
}
