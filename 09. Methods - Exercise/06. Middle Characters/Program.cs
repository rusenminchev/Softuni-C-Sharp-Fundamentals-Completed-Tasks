using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetTheMiddleCharacters(input));
        }

        static string GetTheMiddleCharacters(string input)
        {
            if (input.Length % 2 == 1)
            {
                int middleCharIndex = input.Length / 2;

                return input[middleCharIndex].ToString();
            }
            else if (input.Length % 2 == 0)
            {
                string evenOutput = "";
                int middleCharIndex = input.Length / 2;


                return evenOutput += input[middleCharIndex - 1].ToString() + input[middleCharIndex].ToString();
            }
            return "";
        }

    }
}
