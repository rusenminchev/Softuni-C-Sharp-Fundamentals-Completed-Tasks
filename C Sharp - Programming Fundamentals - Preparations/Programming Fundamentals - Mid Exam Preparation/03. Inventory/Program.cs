using System;
using System.Collections.Generic;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemsAndComands = Console.ReadLine();
            string[] input = itemsAndComands.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> output = new List<string>();
            output.AddRange(input);
            string preCommand = Console.ReadLine();
            while (preCommand != "Craft!")
            {
               
                

                string[] command = preCommand.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < command.Length; i++)
                {

                    for (int j = 0; j < input.Length; j++)
                    {
                        if (command[0] == "Collect")
                        {
                            if (command[1] == input[j])
                            {
                                break;
                            }
                            output.Add(command[1]);
                            break;
                        }
                        else if (command[0] == "Drop")
                        {

                            if (command[1] == input[j])
                            {
                                output.Remove(input[j]);
                            }
                        }
                        else if (command[0] == "Combine" || command[1] == "Items")
                        {

                            string[] combineItems = command[2].Split(':', StringSplitOptions.RemoveEmptyEntries);

                            if (combineItems[0] == input[j])
                            {
                                output.Add((combineItems[1]));
                                i++;
                            }
                            
                        }
                        else if (command[0] == "Renew")
                        {

                            if (command[1] == input[j])
                            {
                                string firstItem = output[0];
                                output.Remove(output[0]);
                                output.Add(firstItem);
   
                            }
                        }
                    }
                }
                preCommand = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", output));

        }
    }
}
