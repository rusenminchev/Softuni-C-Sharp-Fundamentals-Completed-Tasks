using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    continue;
                }
                else
                {
                    if (charCounter.ContainsKey(text[i]))
                    {
                        charCounter[text[i]]++;
                    }
                    else
                    {
                        charCounter.Add(text[i], 1);
                    }
                }
            }

            foreach (var character in charCounter)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
