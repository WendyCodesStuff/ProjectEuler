using System;
using System.Collections.Generic;
using System.Linq;

//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.

// Sieve of Eratosthanes
namespace SummationOfPrimes
{ 
    public class Program
    {
        static List<long> listOfPrimes = new List<long>();

        public static void Main()
        {
            int n = 2000000;

            // Get primes using Sieve of Eratosthenes
            SieveOfEratosthenes(n);

            // Show sum of the primes
            Console.WriteLine("Sum of all primes below " + n + " = " + listOfPrimes.Sum());
           
        }

        public static void SieveOfEratosthenes(int n)
        {
            // Create a boolean array and invert all values to true
            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n; i++)
                prime[i] = true;

            // Iterate through boolean array and set to false if divisible
            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed, then it is a prime 
                if (prime[p] == true)
                {
                    // Update all multiples of p 
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            // Add all primes to the list
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    listOfPrimes.Add(i);
                    
            }

        }
    }
}


