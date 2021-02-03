using System;
using System.Dynamic;
using System.Numerics;

namespace _3._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigFactorial result = new BigFactorial();
            result.n = int.Parse(Console.ReadLine());
            result.GetFactorilNumber();
        }

        public class BigFactorial
        {
            public BigInteger factorial;
            public int n;

            public void GetFactorilNumber()
            {
                factorial = n;
                for (int i = n - 1; i > 0; i--)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
        }
    }
}
