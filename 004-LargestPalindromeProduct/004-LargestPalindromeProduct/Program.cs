using System;
using System.Collections.Generic;
using System.Linq;

// A palindromic number reads the same both ways.The largest palindrome made from the product of
// two 2-digit numbers is 9009 = 91 × 99.

// Find the largest palindrome made from the product of two 3-digit numbers.

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<long> listOfProducts = EnumerateProducts();

            // Start with the highest
            foreach(long product in EnumerateProducts().OrderByDescending(product => product))
            {
                // Is the product a palindrome?
                if (IsPalindrome(product))
                {
                    // This is the largest palindrome so we are done.
                    Console.WriteLine(product.ToString() +
                        " is the largest palindrome that is a product of two 3 digit numbers.");
                    return;
                }

            }

        }

        static IEnumerable<long> EnumerateProducts()
        {
            long lowProduct = 100;
            long highProduct = 999;
            long secondLow = 100;

            //Enumerate products
            for (long i = lowProduct; i <= highProduct; i++)
            {
                for (long j = secondLow; j <= highProduct; j++)
                {
                    long product = i * j;
                    //Console.WriteLine(product.ToString());

                    yield return product;
                }
                // increment the lowest value in our internal loop, because we don't need to resolve
                // the 100x tables again.  We've already done it.
                secondLow++;
            }
        
        }

        static bool IsPalindrome(long number)
        { 
            // Split the number into a list of chars
            string str = number.ToString();
            char[] listChars = str.ToCharArray();
            int numOfChars = (listChars.Length - 1);

            for (int a = 0; a <= numOfChars; a++)
            {
                char firstChar = listChars[a];
                char otherChar = listChars[numOfChars - a];

                // Does this char equal the equivalent reflected char in array?
                // If not, it's not a palindrome, so drop out.
                if (firstChar != otherChar) return false;
            }

            return true;
        }
    }
}
