using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//The following iterative sequence is defined for the set of positive integers:

//n → n/2 (n is even)
//n → 3n + 1 (n is odd)

//Using the rule above and starting with 13, we generate the following sequence:

//13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
//It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

//Which starting number, under one million, produces the longest chain?

//NOTE: Once the chain starts the terms are allowed to go above one million.

namespace Collatz
{
    class Program
    {
        const long maxVal = 1000000;
        static Dictionary<long, long> chainLengths = new Dictionary<long, long>();
        static ConcurrentDictionary<long, long> chainLengthsP = new ConcurrentDictionary<long, long>();

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            DoCollatz();
            long longestChainKey = chainLengths.OrderByDescending(x => x.Value).First().Key;
            long longestChainValue = chainLengths.OrderByDescending(x => x.Value).First().Value;

            DateTime end = DateTime.Now;
            var timeTaken = (end - start).TotalMilliseconds;

            Console.WriteLine($"Starting number {longestChainKey} creates a chain of length {longestChainValue}. Time taken {timeTaken} milliseconds.");

            DateTime startP = DateTime.Now;
            DoCollatzInParallel();
            long longestChainKeyP = chainLengthsP.OrderByDescending(x => x.Value).First().Key;
            long longestChainValueP = chainLengthsP.OrderByDescending(x => x.Value).First().Value;

            DateTime endP = DateTime.Now;
            var timeTakenP = (endP - startP).TotalMilliseconds;

            Console.WriteLine($"With Parallel.For: Starting number {longestChainKeyP} creates a chain of length {longestChainValueP}. Time taken {timeTakenP} milliseconds.");
        }

        static void DoCollatz()
        {
            // loop up to < maxVal of 1 million 
            for (long i = 1; i < maxVal; i++)
            {
                long count = 0;
                long n = i;
                do
                {
                    // if even
                    if (n % 2 == 0)
                    {
                        n = n / 2;

                    }
                    else // odd
                    {
                        n = (3 * n) + 1;
                    }
                    count++;

                } while (n != 1);

                // Add key value pair of <startingnumber> and <lengthofchain>
                chainLengths.Add(i, count);
                
            }
        }

        static void DoCollatzInParallel()
        {
            // Parallel For: loop up to < maxVal of 1 million 
            Parallel.For(1, maxVal-1, (i, state) =>
            {
                long count = 0;
                long n = i;

                do
                {
                    // if even
                    if (n % 2 == 0)
                    {
                        n = n / 2;

                    }
                    else // odd
                    {
                        n = (3 * n) + 1;
                    }
                    count++;

                } while (n != 1);

                // Add keyvalue pair to Concurrent Dictionary
                chainLengthsP.TryAdd(i, count);
            });
        }
    }
}