using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "End")
            {
                List<string> elements = commands.Split().ToList();
                string command = elements[0];

                if (command == "Add")
                {
                    int number = int.Parse(elements[1]);
                    input.Add(number);

                }
                else if (command == "Insert")
                {
                    int number = int.Parse(elements[1]);
                    int index = int.Parse(elements[2]);
                    
                    if (index >= 0 && index <= input.Count - 1)
                    { 
                        input.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(elements[1]);
                    if (index >= 0 && index <= input.Count - 1)
                    {
                        input.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Shift")
                {
                    if (elements[1] == "left")
                    {
                        int count = int.Parse(elements[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = input[0];
                            input.Remove(input[0]);
                            input.Add(firstNum);
                            
                        }
                    }
                    else if ((elements[1] == "right"))
                    {
                        int lastNum = input[input.Count - 1];
                        input.Remove(input[input.Count - 1]);
                        input.Insert(0, lastNum);
                    }

                }
            }

            Console.WriteLine(String.Join(" ", input));
          
        }
    }
}
