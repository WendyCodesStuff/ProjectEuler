using System;
using System.Numerics;

// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
// there are exactly 6 routes to the bottom right corner.

// How many such routes are there through a 20×20 grid?

// Answer is the binomial coefficent [n+r | r] where the grid starts at (0,0) and ends at (n,r)
// To calculate this, we use the formula: (n+r)! / (n! * r!)

namespace LatticePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            // BigIntegers can't be declared as const
            BigInteger n = 20;
            BigInteger r = 20;

            // (n+r)! / (n! * r!)
            Console.WriteLine(Factorial(n+r) / (Factorial(n) * Factorial(r)));
        }

        static BigInteger Factorial(BigInteger num)
        {
            // Loop through up to num cumulating the products
            BigInteger cumulative = 1;

            for (BigInteger i = 1; i <= num; i++)
            {
                cumulative = cumulative * i;
            }
            return cumulative;
        }
    }
}
