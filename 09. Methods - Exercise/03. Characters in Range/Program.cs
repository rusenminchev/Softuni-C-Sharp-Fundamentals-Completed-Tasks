using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            Console.WriteLine(CharactersBetweenTwoChars(ch1, ch2));
        }

        static string CharactersBetweenTwoChars(char ch1, char ch2)
        {

            string output = "";
            if (ch1 < ch2)
            {
                for (int i = ch1 + 1; i < ch2; i++)
                {
                    output += (char)i + " ";
                }
            }
            else
            {
                for (int i = ch2 + 1; i < ch1; i++)
                {
                    output += (char)i + " ";
                }

            }

            return output;
        }

    }
}
