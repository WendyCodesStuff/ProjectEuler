using System;
using System.Numerics;

namespace Power_Digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get 2^1000 and convert to string
            BigInteger bigNumber = BigInteger.Pow(2, 1000);
            string stringBigNum = bigNumber.ToString();
            long lengthOfBigNum = stringBigNum.Length;
            int counter = 0;
            long total = 0;

            for (int i = 0; i < lengthOfBigNum; i++)
            {
                // Get next number in bigNumber string and add to total
                total = total + Int32.Parse(stringBigNum.Substring(counter, 1));
                counter++;
            }

            // What's the total
            Console.WriteLine("2^1000 = " + bigNumber + ". Digits added together makes: " + total);
        }
    }
}
