using System;
using System.Collections.Generic;
using System.Linq;

// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const long highestValue = 4000000;

            // Get the sum of the list of even Fibonaccis
            long total = EnumerateEvenFibonacci(highestValue).Sum();

            Console.WriteLine(total);
        }

        public static IEnumerable<long> EnumerateEvenFibonacci(long maxVal)
        {
            long current = 1;
            long previous = 0;

            while (current < maxVal)
            {
                // return this Fibonacci only if it is even
                if (current % 2 == 0)
                    yield return current;

                // Add current to previous to product Fibonacci
                long temp = previous;
                previous = current;
                current += temp;
            }
        }
    }
}
