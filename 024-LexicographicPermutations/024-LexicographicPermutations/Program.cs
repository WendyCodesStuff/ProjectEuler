using System;

// A permutation is an ordered arrangement of objects.For example, 3124 is one possible permutation of the digits
// 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.
// The lexicographic permutations of 0, 1 and 2 are:

// 012   021   102   120   201   210

// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

namespace LexicographicPermutations
{
    class Program
    {
        static int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        static void Main(string[] args)
        {
            
            int count = 1;
            const int max = 1000000;

            while (count < max)
            {
                int length = digits.Length;
                int i = length - 1;

                // Get the i number to swap
                while (digits[i - 1] >= digits[i])
                {
                    i--;

                }

                int j = length;

                // Get the j number to swap
                while (digits[j - 1] <= digits[i - 1])
                {
                    j--;
                }

                // Swap values at position i-1 and j-1
                Swap(i - 1, j - 1);

                i++;
                j = length;

                // Continue to swap and increment i, decrement j
                while (i < j) {
                    Swap(i - 1, j - 1);
                    i++;
                    j--;
                }
                count++;
            }

            string permutation = "";

            // Concatenate numbers from the array onto the string
            for (int k = 0; k < digits.Length; k++)
            {
                permutation += digits[k];
            }

            Console.WriteLine("Millionth lexicographic permutation: " + permutation);
        }

        static void Swap(int i, int j)
        {
            int k = digits[i];
            digits[i] = digits[j];
            digits[j] = k;
        }
    }
}
