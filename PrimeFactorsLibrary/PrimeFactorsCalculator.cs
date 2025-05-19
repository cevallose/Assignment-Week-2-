using System;
using System.Collections.Generic;

namespace PrimeFactorsLibrary
{
    public static class PrimeFactorsCalculator
    {
        public static string PrimeFactors(int n)
        {
            if (n < 2 || n > 1000)
                throw new ArgumentOutOfRangeException(nameof(n), "Value must be between 2 and 1000.");

            var factors = new List<int>();
            int divisor = 2;

            while (n > 1)
            {
                if (n % divisor == 0)
                {
                    factors.Add(divisor);
                    n /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            factors.Reverse();  // optional: largest-first
            return string.Join(" x ", factors);
        }
    }
}
