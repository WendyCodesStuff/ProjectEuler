using System;

// The sum of the squares of the first ten natural numbers is,

// 1^2 + 2^2 + ... + 10^2 = 385
// The square of the sum of the first ten natural numbers is,

// (1 + 2 + ... + 10)^2 = 55^2 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace _006_SumSquareDifference
{
    class Program
    {
        const long max = 100;

        static void Main(string[] args)
        {

            long difference = SquareOfSums() - SumOfSquares();

            Console.WriteLine(difference);
        }

        static long SquareOfSums()
        {
            long runningTotal = 0;

               // Sum of the square
            for (long i = 1; i <= max; i++)
            {
                runningTotal = runningTotal + i;
            }

            Console.WriteLine(runningTotal * runningTotal);
            return (runningTotal * runningTotal);
            
        }

        static long SumOfSquares()
        {
            long runningTotal = 0;

            // Square of the sum
            for (long i = 1; i <= max; i++)
            {
                runningTotal = runningTotal + (i * i);
            }

            Console.WriteLine(runningTotal);
            return runningTotal;
        }

    }
}
