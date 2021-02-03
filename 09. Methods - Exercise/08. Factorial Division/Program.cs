using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(GetFactorial(n1) / GetFactorial(n2)):f2}");
        }

        static double GetFactorial(int n1)
        {
            double factorial = n1;
            for (int i = n1 - 1; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
