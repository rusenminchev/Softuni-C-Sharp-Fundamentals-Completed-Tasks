using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            // Да намерим най-дългата поредица от еднакви числа
            // Ако са повече от 1, да изпечатаме най-лявата

            // 2 1 1 2 3 3 2 2 2 1

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lenght = 1;
            int maxLenght = 0;

            int start = 0;
            int bestStart = 0;
           

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    
                    lenght++;
                }
                else
                {
                    lenght = 1;
                    start = i;
                }
                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + maxLenght; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
