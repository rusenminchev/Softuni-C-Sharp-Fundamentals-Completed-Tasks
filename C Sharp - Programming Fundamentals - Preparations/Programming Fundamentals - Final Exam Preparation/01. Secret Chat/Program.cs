using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _01._Secret_Chat___10_April_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                if (command.Contains("InsertSpace"))
                {
                    string[] splitted = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                    int index = int.Parse(splitted[1]);

                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                if (command.Contains("Reverse"))
                {
                    string[] splitted = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                    string substring = splitted[1];

                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring[0]);
                        message = message.Remove(index, substring.Length);

                        char[] charArray = substring.ToCharArray();
                        Array.Reverse(charArray);
                        string reversed = new string(charArray);

                        message += reversed;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (command.Contains("ChangeAll"))
                {
                    string[] splitted = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                    string substring = splitted[1];
                    string replacement = splitted[2];

                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                        Console.WriteLine(message);
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
