using System;
using System.Collections.Generic;

//If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

//If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


//NOTE: Do not count spaces or hyphens.For example,
//    342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
//    The use of "and" when writing out numbers is in compliance with British usage.


namespace NumberLetterCounts
{
    class Program
    {
        static int and = "and".Length;
        static int hundred = "hundred".Length;
        static int oneThousand = "onethousand".Length;

        static void Main(string[] args)
        {
            // Keys are all numbers 1 to 19, 20-90 in 10's
            // Values are the words of each of these numbers
            Dictionary<int, string> dictOfWords = new Dictionary<int, string>();

            // Fill Dictionary
            FillDictionaryWithWords(dictOfWords);
            long totalLetters = CountLetters(dictOfWords);

            Console.WriteLine("Total letters = " + totalLetters);
        }

        static void FillDictionaryWithWords(Dictionary<int, string> dictOfWordsFill)
        {
            // Numbers 1 to 19
            dictOfWordsFill.TryAdd(1, "one");
            dictOfWordsFill.TryAdd(2, "two");
            dictOfWordsFill.TryAdd(3, "three");
            dictOfWordsFill.TryAdd(4, "four");
            dictOfWordsFill.TryAdd(5, "five");
            dictOfWordsFill.TryAdd(6, "six");
            dictOfWordsFill.TryAdd(7, "seven");
            dictOfWordsFill.TryAdd(8, "eight");
            dictOfWordsFill.TryAdd(9, "nine");
            dictOfWordsFill.TryAdd(10, "ten");
            dictOfWordsFill.TryAdd(11, "eleven");
            dictOfWordsFill.TryAdd(12, "twelve");
            dictOfWordsFill.TryAdd(13, "thirteen");
            dictOfWordsFill.TryAdd(14, "fourteen");
            dictOfWordsFill.TryAdd(15, "fifteen");
            dictOfWordsFill.TryAdd(16, "sixteen");
            dictOfWordsFill.TryAdd(17, "seventeen");
            dictOfWordsFill.TryAdd(18, "eighteen");
            dictOfWordsFill.TryAdd(19, "nineteen");
            // 20-90 in tens
            dictOfWordsFill.TryAdd(20, "twenty");
            dictOfWordsFill.TryAdd(30, "thirty");
            dictOfWordsFill.TryAdd(40, "forty");
            dictOfWordsFill.TryAdd(50, "fifty");
            dictOfWordsFill.TryAdd(60, "sixty");
            dictOfWordsFill.TryAdd(70, "seventy");
            dictOfWordsFill.TryAdd(80, "eighty");
            dictOfWordsFill.TryAdd(90, "ninety");
        }

        static long CountLetters(Dictionary<int, string> dictToOfWords)
        {
            try
            {
                // Your starter for one thousand
                long runningTotal = oneThousand;

                // prefix to "hundred", eg "one" hundred, "two" hundred repeated 100 times each
                int prefixHundred = 0;

                for (int i = 1; i <= 9; i++)
                {
                    string word;
                    dictToOfWords.TryGetValue(i, out word);
                    if (word != null)
                        prefixHundred += word.Length;
                }
                runningTotal += (prefixHundred * 100);

                // Words that include "hundred"
                runningTotal += (hundred * 900);

                // Words that include "and" ie, All that include "hundred" minus the number of exact hundreds
                runningTotal += (and * (900 - 9));

                // Numbers 1-19 are repeated 10 times each
                int oneTo19 = 0;

                for (int i = 1; i <= 19; i++)
                {
                    string word;
                    dictToOfWords.TryGetValue(i, out word);
                    if (word != null)
                        oneTo19 += word.Length;
                }
                runningTotal += (10 * oneTo19);

                // The words twenty, thirty etc are repeated 100 times each
                int twentyTo90 = 0;

                for (int i = 20; i <=90; i+=10)
                {
                    string word;
                    dictToOfWords.TryGetValue(i, out word);
                    if (word != null)
                        twentyTo90 += word.Length;
                }
                runningTotal += (100 * twentyTo90);

                // Units that follow twenty, thirty etc are repeated 80 times each
                int units = 0;

                for (int i = 1; i <= 9; i++)
                {
                    string word;
                    dictToOfWords.TryGetValue(i, out word);
                    if (word != null)
                        units += word.Length;
                }
                runningTotal += (80 * units);

                return runningTotal;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message + e.StackTrace );
                return 0;
            }
        }
    }
}
