using System;
namespace soucetcifer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš číslo : ");
            int number = int.Parse(Console.ReadLine());
            int sum = soucetcisel(number);
            Console.WriteLine($"Součet čísel je: {sum}");
        }

        static int soucetcisel(int number)
        {
            if (number != 0)
            {
                return (number % 10 + soucetcisel(number / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}