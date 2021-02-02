using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            double cources = Math.Ceiling(numOFPeople / (double)elevatorCapacity);

            Console.WriteLine(cources);
        }
    }
}
