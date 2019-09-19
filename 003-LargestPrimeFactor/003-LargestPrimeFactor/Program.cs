using System;
using System.Linq;
using System.Collections.Generic;

// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143?

namespace LargestPrimeFactor
{
    class Program
    {
        const long hugeValue = 600851475143;

        static void Main(string[] args)
        {

            long largestPrimeFactor = 0;

            IEnumerable<long> allFactors = EnumerateFactors(hugeValue);

            // Find the primes in this list of factors, starting with the largest.
            foreach (long number in EnumerateFactors(hugeValue).OrderByDescending(number => number))

            {
                Console.WriteLine("number = " + number);

                // Is this a prime?
                if (IsPrime(number))
                {
                    largestPrimeFactor = number;
                    Console.WriteLine("Largest prime factor: " + largestPrimeFactor);

                    // We are going from largest to smallest, so this IS the largest and we can drop out now.
                    break;

                }
            }
        }

        // Enumerate factors in pairs. ie, When we find the smallest factor, we can imply its corresponding
        // factor.  We can also assume there will be no factors higher than this so reset top of the loop.
        public static IEnumerable<long> EnumerateFactors(long maxValue)
        {

            long low = 2;
            long high = maxValue;
        
            for (long i = low; i <= high/2; i++)
                {
                    // Is this a factor of maxValue?
                    if (maxValue % i == 0)
                    {
                        // return this factor
                        yield return i;

                        // return its corresponding factor
                        long correspondingFactor = (maxValue / i);
                        yield return correspondingFactor;

                        // reset the top of the loop, no need to go beyond largest factor
                        high = correspondingFactor - 1;
                    }

                }

        }

        static bool IsPrime(long possiblePrime)
        {
            
            long low = 2;
            long high = possiblePrime;

            // Loop through, checking if possiblePrime is actually a prime
            for (long f = low; f < possiblePrime; f++)
            {
                // Any remainder if we divide prime by potential factor?
                if (possiblePrime % f == 0)
                {
                    // No remainder so this is not a prime
                    return false;
                }
            }

            // no factors found so this is a prime
            return true;
        }
    }
}

