using System;
using PrimeFactorsLibrary;

namespace PrimeFactorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer (2–1000): ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            try
            {
                var factors = PrimeFactorsCalculator.PrimeFactors(n);
                Console.WriteLine($"{n} = {factors}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
