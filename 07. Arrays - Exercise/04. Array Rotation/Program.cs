using System;
using System.Linq;

namespace _04._Array_Rotation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
        
            for (int j = 0; j < n; j++)
            {

                int first = array[0];

                for (int i = 0; i < array.Length - 1; i++)
                {         
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = first;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
