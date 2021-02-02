using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += num;
                Console.WriteLine(num);

                num += 2;

            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
