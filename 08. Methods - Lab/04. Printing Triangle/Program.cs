﻿using System;
using System.Runtime.CompilerServices;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintTriangles(1, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintTriangles(1, i);
            }

        }

        static void PrintTriangles(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
