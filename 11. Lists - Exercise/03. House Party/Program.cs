using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            List<string> command = new List<string>();

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split().ToList();
                string name = command[0];

                if (command[2] == "going!")
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (command[2] == "not")
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }


            }

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }

        }
    }
}
