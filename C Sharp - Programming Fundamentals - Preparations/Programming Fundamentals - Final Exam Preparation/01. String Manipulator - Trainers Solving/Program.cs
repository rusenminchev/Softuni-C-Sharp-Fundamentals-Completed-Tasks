using System;

namespace _01._String_Manipulator___Trainers_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Translate")
                {
                    char oldChar = char.Parse(tokens[1]);
                    char replacement = char.Parse(tokens[2]);

                    input = input.Replace(oldChar, replacement);
                    Console.WriteLine(input);
                }
                else if (action == "Includes")
                {
                    string substring = tokens[1];

                    bool result = input.Contains(substring);
                    Console.WriteLine(result);
                }
                else if (action == "Start")
                {
                    string substring = tokens[1];

                    bool result = input.StartsWith(substring);
                    Console.WriteLine(result);

                }
                else if (action == "Lowercase")
                {

                    input = input.ToLower();

                    Console.WriteLine(input);
                }
                else if (action == "FindIndex")
                {

                    string character = tokens[1];

                    int lastIndex = input.LastIndexOf(character);

                    Console.WriteLine(lastIndex);

                }
                else if (action == "Remove")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int count = int.Parse(tokens[2]);

                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }
                command = Console.ReadLine();
            }
        }
    }
}
