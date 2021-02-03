using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Добър пример за разделянето на различни елементи според техния индекс.

            int n = int.Parse(Console.ReadLine());
            
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(i % 2 == 0)
                {
                    array1[i] = currentLine[0];
                    array2[i] = currentLine[1];
                }
                if (i % 2 == 1)
                {
                    array1[i] = currentLine[1];
                    array2[i] = currentLine[0];
                }
            }
            Console.WriteLine(String.Join(' ', array1));
            Console.WriteLine(String.Join(' ', array2));
        }
    }
}
