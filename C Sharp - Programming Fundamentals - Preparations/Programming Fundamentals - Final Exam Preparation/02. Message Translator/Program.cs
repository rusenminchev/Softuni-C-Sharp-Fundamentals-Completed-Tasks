using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\!(?<command>[A-Z][a-z]{2,})\!:\[(?<message>[A-Za-z]{8,})\]");

            int n = int.Parse(Console.ReadLine());

            List<int> encryptedMessage = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match isValid = pattern.Match(input);

                if (isValid.Success)
                {
                    string command = isValid.Groups["command"].ToString();
                    string message = isValid.Groups["message"].ToString();

                    for (int j = 0; j < message.Length; j++)
                    {
                        encryptedMessage.Add((char)message[j]);
                    }

                    Console.WriteLine($"{command}: " + String.Join(" ", encryptedMessage));
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
