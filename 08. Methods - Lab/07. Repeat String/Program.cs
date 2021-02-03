using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRepeat = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            string output = RepeatStringNTimes(stringToRepeat, repeatCount);

            Console.WriteLine(output);

        }

        static string RepeatStringNTimes(string toRepeat, int counter)
        {
            string finalString = "";
            for (int i = 0; i < counter; i++)
            {
                finalString += toRepeat;
            }
            return finalString;
        }
    }
}
