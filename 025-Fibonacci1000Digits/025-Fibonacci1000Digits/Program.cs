using System;
using System.Numerics;

//The Fibonacci sequence is defined by the recurrence relation:

//Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
//Hence the first 12 terms will be:

//F1 = 1
//F2 = 1
//F3 = 2
//F4 = 3
//F5 = 5
//F6 = 8
//F7 = 13
//F8 = 21
//F9 = 34
//F10 = 55
//F11 = 89
//F12 = 144
//The 12th term, F12, is the first term to contain three digits.

// What is the index of the first term in the Fibonacci sequence to contain 1000 digits?

namespace Fibonacci1000Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start at an index of 12
            int endDigits = 1000;
            int currentIndex = 2;
            BigInteger fibonacci = 1;
            BigInteger fibonacci2 = 1;

            do
            {
                // Get Fibonacci of current index
                BigInteger fibonacci3 = fibonacci;
                fibonacci += fibonacci2;
                fibonacci2 = fibonacci3;

                currentIndex++;


            } while (fibonacci.ToString().Length < endDigits);

            Console.WriteLine("F" + endDigits + " = " + currentIndex);
        }
    }
}
