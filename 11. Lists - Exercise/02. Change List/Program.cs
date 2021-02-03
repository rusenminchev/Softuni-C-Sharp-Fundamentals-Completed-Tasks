using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;

            while (((command = Console.ReadLine()) != "end"))
            {
                List<string> elements = command.Split().ToList();
                string action = elements[0];

                if (action == "Delete")
                {
                    int element = int.Parse(elements[1]);

                    for (int i = 0; i < input.Count; i++)
                    {
                            input.Remove(element);
                    }

                }
                else if (action == "Insert")
                {
                    int element = int.Parse(elements[1]);
                    int position = int.Parse(elements[2]);

                    input.Insert(position, element);
                }
            }

            Console.WriteLine(String.Join(" ",input));

        }

        
	

    }
}
