using System;
using System.Collections.Generic;
using System.Linq;

// Let d(n) be defined as the sum of proper divisors of n(numbers less than n which divide evenly into n).
// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.
// The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

// Evaluate the sum of all the amicable numbers under 10000. 


namespace AmicableNumbers
{
    class Program
    {
        const long topValue = 10000;

        static void Main(string[] args)
        {

            List<long> amicableFactors = new List<long>();

            // Loop through numbers up to maxValue
            for (long i = 1; i < topValue; i++)
            {
                // Continue only if we haven't already recognised this as an amicable number
                if (!amicableFactors.Contains(i))
                {
                    // Get sum of factors of this number
                    long j = GetTotalOfFactors(i);

                    if (i == GetTotalOfFactors(j) && (i != j))
                    { 
                        amicableFactors.Add(i);
                        amicableFactors.Add(j);
                    }

                }

            }

            // Display total
            Console.WriteLine(amicableFactors.Sum());
        }

        static long GetTotalOfFactors(long topValue)
        {
            long runningTotal = 0;

            // Add together the factors of amicableA
            for (long j = 1; j < topValue; j++)
            {
                // If this is a factor, add to running total
                if (topValue % j == 0)
                    runningTotal += j;
            }

            return runningTotal;
        }
           

}
}
