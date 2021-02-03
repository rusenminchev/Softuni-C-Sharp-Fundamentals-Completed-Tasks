using System;
using System.Runtime.CompilerServices;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(VolewsCount(input));
        }

        static int VolewsCount(string input)
        {

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A')
                {
                    counter++;
                }

                if (input[i] == 'e' || input[i] == 'E')
                {
                    counter++;
                }

                if (input[i] == 'i' || input[i] == 'I')
                {
                    counter++;
                }

                if (input[i] == 'o' || input[i] == 'O')
                {
                    counter++;
                }

                if (input[i] == 'u' || input[i] == 'U')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
