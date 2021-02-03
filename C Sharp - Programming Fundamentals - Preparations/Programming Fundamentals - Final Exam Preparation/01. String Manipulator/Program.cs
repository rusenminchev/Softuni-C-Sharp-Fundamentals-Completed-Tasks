using System;
using System.Linq;

namespace _01._String_Manipulator
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
                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Start")
                {
                    string substring = tokens[1];
                    bool isStartWithTheSub = false;

                    for (int i = 0; i < substring.Length; i++)
                    {
                        if (input[i] == substring[i])
                        {
                            isStartWithTheSub = true;
                        }
                        else
                        {
                            isStartWithTheSub = false;
                        }
                    }

                    if (isStartWithTheSub)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (action == "Lowercase")
                {

                    for (int i = 0; i < input.Length; i++)
                    {
                        char current = char.ToLower(input[i]);
                        input = input.Replace(input[i], current);
                    }
                    Console.WriteLine(input);
                }
                else if (action == "FindIndex")
                {

                    char charToFind = char.Parse(tokens[1]);
                    char[] charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                    string rev = new string(charArray);

                    int revIndex = rev.IndexOf(charToFind);
                    int neededIndex = input.Length - 1 - revIndex;

                    Console.WriteLine(neededIndex);

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
