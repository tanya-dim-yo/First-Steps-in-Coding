using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double sum = area * 7.61;
            double discount = (sum * 18) / 100;
            double totalSum = sum - discount;
            Console.WriteLine($"The final price is: {totalSum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }

    }

}