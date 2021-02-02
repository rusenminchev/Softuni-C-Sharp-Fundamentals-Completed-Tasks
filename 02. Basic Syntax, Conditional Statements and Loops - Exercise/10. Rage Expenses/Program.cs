using System;
using System.Xml.Schema;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int losesCount = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int headsetTrashCount = losesCount / 2;
            int mouseTrashCount = losesCount / 3;
            int keyboardTrashCount = losesCount / 6;
            int displayTrashCount = losesCount / 12;

            double totalRageExpenses = (headsetTrashCount * headset) + (mouseTrashCount * mouse) + (keyboardTrashCount * keyboard) + (displayTrashCount * display);

            Console.WriteLine($"Rage expenses: {totalRageExpenses:f2} lv.");
        }
    }
}
