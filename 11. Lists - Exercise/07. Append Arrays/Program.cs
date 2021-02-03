using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').Where(s => !string.IsNullOrWhiteSpace(s)).Reverse().ToList();



            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                arrays[i] = arrays[i].Trim();
                
                    arrays[i] = arrays[i].Replace("  ", " ");
            
            }

            Console.WriteLine(string.Join(' ', arrays));

        }
    }
}
