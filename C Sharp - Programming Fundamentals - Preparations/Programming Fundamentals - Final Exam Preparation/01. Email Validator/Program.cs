using System;
using System.IO;
using System.Linq;
using System.Net.Security;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Make")
                {
                    string casing = tokens[1];
                    if (casing == "Upper")
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            char current = char.ToUpper(input[i]);
                            input = input.Replace(input[i], current);

                        }
                        Console.WriteLine(input);

                    }
                    else if (casing == "Lower")
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            char current = char.ToLower(input[i]);
                            input = input.Replace(input[i], current);

                        }
                        Console.WriteLine(input);

                    }

                }
                else if (action == "GetDomain")
                {
                    int count = int.Parse(tokens[1]);
                    var result = input.Substring(input.Length - 3);
                    Console.WriteLine(result);

                }
                else if (action == "GetUsername")
                {
                    if (input.Contains('@'))
                    {
                        Console.WriteLine(input.Substring(0, input.IndexOf('@')));
                    }
                    else
                    {
                        Console.WriteLine($"The email {input} doesn't contain the @ symbol.");
                    }
                }
                else if (action == "Replace")
                {
                    char charToReplace = char.Parse(tokens[1]);
                   input = input.Replace(charToReplace, '-');
                    Console.WriteLine(input);
                }
                else if (action == "Encrypt")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        Console.Write((int)input[i] + " ");
                    }
                }


                command = Console.ReadLine();
            }
        }
    }
}
