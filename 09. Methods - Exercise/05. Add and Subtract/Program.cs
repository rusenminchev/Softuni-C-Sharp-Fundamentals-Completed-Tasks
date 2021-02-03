using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(n1, n2) - Subtract(n3));
        }

        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Subtract(int n3)
        {
            return n3;
        }
    }
}
