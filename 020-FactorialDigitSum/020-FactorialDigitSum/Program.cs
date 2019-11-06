using System;
using System.Numerics;

//n! means n × (n − 1) × ... × 3 × 2 × 1

//For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
//and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

//Find the sum of the digits in the number 100!

namespace FactorialDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;

            // Find 100!
            for(int i = 100; i > 0;  i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

            // Covert to a string
            string stringFactorial = factorial.ToString();
            long runningTotal = 0;

            // Add the digits
            for(int i = 0; i <= stringFactorial.Length -1; i++)
            {
                // Add next number
                runningTotal += Convert.ToInt64(stringFactorial.Substring(i, 1));
            }

            Console.WriteLine("Total = " + runningTotal);
        }
    }
}
