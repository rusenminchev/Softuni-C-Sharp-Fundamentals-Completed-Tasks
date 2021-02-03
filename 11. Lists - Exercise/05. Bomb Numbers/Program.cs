using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> bombNumAndItsPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bombNumber = bombNumAndItsPower[0];
            int power = bombNumAndItsPower[1];
            int counter = 1 + power + power;


            for (int i = 0; i < input.Count; i++)
            {
                counter = 1 + power + power;
                if (input[i] == bombNumber)
                {
                    for (int k = i - power; k < i + power; k++)
                    {
                        if (k > input.Count - 1)
                        {
                            continue;
                        }

                        input.RemoveAt(k);
                        k--;
                        counter--;
                        if (counter == 0)
                        {
                            break;
                        }
                    }   
                }
            }

            int sum = 0;

            for (int j = 0; j < input.Count; j++)
            {
                sum += input[j];
            }

            Console.WriteLine(sum);
        }
    }
}
