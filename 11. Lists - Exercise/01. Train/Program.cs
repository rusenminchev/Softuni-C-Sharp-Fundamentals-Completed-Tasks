using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {

                List<string> elements = command.Split().ToList();
                if (elements.Count > 1)
                {
                    string action = elements[0];
                    int passengers = int.Parse(elements[1]);

                    wagons.Add(passengers);

                }
                else
                {
                    int passengers = int.Parse(elements[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
