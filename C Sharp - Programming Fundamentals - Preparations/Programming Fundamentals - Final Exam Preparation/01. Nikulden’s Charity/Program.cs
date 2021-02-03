using System;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] tokens = command.Split();
                string action = tokens[0];


                if (action == "Replace")
                {
                    char currentChar = char.Parse(tokens[1]);
                    char newChar = char.Parse(tokens[2]);

                    message = message.Replace(currentChar, newChar);
                    Console.WriteLine(message);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int lenght = endIndex + 1 - startIndex;

                    if (startIndex < 0 || endIndex > message.Length - 1)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        message = message.Remove(startIndex, lenght);
                        Console.WriteLine(message);
                    }
                }
                if (action == "Make")
                {
                    string casing = tokens[1];

                    if (casing == "Upper")
                    {
                        for (int i = 0; i < message.Length; i++)
                        {  
                                char currentChar = char.ToUpper(message[i]);
                               message = message.Replace(message[i], currentChar);
                        }

                    }
                    else if (casing == "Lower")
                    {
                        for (int i = 0; i < message.Length; i++)
                        {
   
                                char currentChar = char.ToLower(message[i]);
                            message = message.Replace(message[i], currentChar);
                            
                        }
                    }

                    Console.WriteLine(message);

                }
                if (action == "Check")
                {
                    string stringToCheck = tokens[1];

                    if (message.Contains(stringToCheck))
                    {
                        Console.WriteLine($"Message contains {stringToCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {stringToCheck}");
                    }
                }
                if (action == "Sum")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex < 0 || endIndex > message.Length - 1)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        int charsSum = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            charsSum += (int)message[i];
                        }

                        Console.WriteLine(charsSum);
                    }
                    

                }
                command = Console.ReadLine();
            }

        }
    }
}
