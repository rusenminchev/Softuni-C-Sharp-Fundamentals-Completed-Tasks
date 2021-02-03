using System;
using System.Linq;

namespace Activaiton_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] actions = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (actions.Contains("Contains"))
                {
                    string substring = actions[1];

                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                if (actions.Contains("Flip"))
                {
                    string direction = actions[1];
                    int startIndex = int.Parse(actions[2]);
                    int endIndex = int.Parse(actions[3]);

                    if (direction == "Upper")
                    {
                        string modifiednSub = string.Empty;

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char current = char.ToUpper(rawActivationKey[i]);
                            modifiednSub += current;
                        }
                        int lenght = endIndex - startIndex;
                        rawActivationKey = rawActivationKey.Remove(startIndex, lenght);
                        rawActivationKey = rawActivationKey.Insert(startIndex, modifiednSub);
                    }
                    if (direction == "Lower")
                    {
                        string modifiednSub = string.Empty;
                        
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char current = char.ToLower(rawActivationKey[i]);
                            modifiednSub += current;
                        }
                        int lenght = endIndex - startIndex;
                        rawActivationKey = rawActivationKey.Remove(startIndex, lenght);
                        rawActivationKey = rawActivationKey.Insert(startIndex, modifiednSub);
                    }

                    Console.WriteLine(rawActivationKey);
                }
                else if (actions.Contains("Slice"))
                {
                    int startIndex = int.Parse(actions[1]);
                    int endIndex = int.Parse(actions[2]);
                    int lenght = endIndex - startIndex;

                    rawActivationKey = rawActivationKey.Remove(startIndex, lenght);
                    Console.WriteLine(rawActivationKey);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
