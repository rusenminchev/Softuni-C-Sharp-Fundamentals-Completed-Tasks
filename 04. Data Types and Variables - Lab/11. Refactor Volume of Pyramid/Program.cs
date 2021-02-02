using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double volume = ((length * width) / 3) * height;

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
