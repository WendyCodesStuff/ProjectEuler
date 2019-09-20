using System;
using System.Collections.Generic;

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
// answer 232792560

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //const long biggestFactor = 20;
            const long startAt = 2520;
            long max = 100000000000;
            long i = 0;
            long iteration = 2520;

            DateTime start = DateTime.Now;

            // test all these numbers
            // looping up to a maximum value, rather than while true,just in case none are found.
            for (i = startAt; i <= max; i = i+ iteration)
            {
                //if (divisibleNumber(i, biggestFactor))
                if (divisibleNumber(i))
                {
                    Console.WriteLine(i.ToString());
                    break;
                }
            }
       
            DateTime end = DateTime.Now;
            Console.WriteLine("Time taken: " + (start - end).TotalSeconds.ToString() + " seconds");
        }

        static bool divisibleNumber(long biggestSoFar)
        {
            long[] listOfFactors = { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 };

            //see if j is divisible by all numbers from 2 to 10
            foreach(long factor in listOfFactors)
            {
                if (biggestSoFar % factor != 0)
                    return false;
            }
            // We got this far so must have succesfully divided by all
            return true;
        }
    }
}
