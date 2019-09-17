using System;
using System.Linq;
using System.Collections.Generic;

// Find the sum of all the multiples of 3 or 5 below 1000.

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            const long firstFactor = 3;
            const long secondFactor = 5;

            // multiples of 15 will be counted twice so we need to remove one set
            const long eliminateFactor = 15;

            const long maxValue = 1000;

            // Declare an interface to the iEnumerable 
            IEnumerable<long> firstSequence = EnumerateMultiples(firstFactor, maxValue);
            IEnumerable<long> secondSequence = EnumerateMultiples(secondFactor, maxValue);
            IEnumerable<long> eliminateSequence = EnumerateMultiples(eliminateFactor, maxValue);

            // Get the sum of each list of multiples
            long firstTotal = firstSequence.Sum();
            long secondTotal = secondSequence.Sum();
            long eliminateTotal = eliminateSequence.Sum();

            // (sum of 3s) + (sum of 5s) - (sum of 15s) - put over-simply
            long totalMultiples = firstTotal + secondTotal - eliminateTotal;

            Console.WriteLine(firstTotal + " + " + secondTotal + " - " + eliminateTotal + " = " + totalMultiples);

        }

        // Method to return a list of all multiples of a factor below maxMultiple
        public static IEnumerable<long> EnumerateMultiples(long Factor, long maxMultiple)
        {
            long current = 1;
            long multiple = 0;
            long sum = 0;

            do
            {
                multiple = current * Factor;
                yield return multiple;
                sum = sum + multiple;
                current++;

            } while (multiple < (maxMultiple - Factor));
        }
    }
    
}
