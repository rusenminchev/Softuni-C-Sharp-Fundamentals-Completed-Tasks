using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char operator1 = char.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (operator1 == '/')
            {
                Console.WriteLine(Divide(n1, n2));
            }
            if (operator1 == '*')
            {
                Console.WriteLine(Multiply(n1, n2));
            }
            if (operator1 == '+')
            {
                Console.WriteLine(Add(n1, n2));
            }
            if (operator1 == '-')
            {
                Console.WriteLine(Subtract(n1, n2));
            }
        }

        static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }

        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
