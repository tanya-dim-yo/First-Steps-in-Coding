using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tinsDogs = int.Parse(Console.ReadLine());
            int tinsCats = int.Parse(Console.ReadLine());
            double sum = (tinsDogs * 2.50) + (tinsCats * 4.00);
            Console.WriteLine($"{sum} lv.");
        }
    }
}