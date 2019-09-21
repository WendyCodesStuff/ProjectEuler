using System;
using System.Collections.Generic;

//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

//What is the 10,001st prime number?

namespace _1001stPrime
{
    class Program
    {
        static List<long> primes = new List<long>(1);

        static void Main(string[] args)
        {
            int positionOfPrime = 10001;
            long i = 2;

            // Loop through each number to topPrime
            while(primes.Count <= (positionOfPrime-1))
            {
               
                if (isPrime(i))
                {
                    // We found a prime, so add to list
                    primes.Add(i);
               
                }
                i++;
                
            }
            // What is our 10001st prime?
            long thePrime = primes[positionOfPrime-1];

            Console.WriteLine((positionOfPrime).ToString() + "st prime is " + thePrime.ToString());
        }

        static bool isPrime(long number)
        {
           
            // Loop through each prime to see if it is a factor of this number
            foreach (long prime in primes)
            {
                if (number % prime == 0)
                {
                    // found a factor so this is not a prime
                    return false;
                }
            }
            
            // Found no factors so this is a prime
            return true;
        }
}
}
