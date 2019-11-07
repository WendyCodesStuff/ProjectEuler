using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Using names.txt, a 46K text file containing over five-thousand first names,
// begin by sorting it into alphabetical order. Then working out the alphabetical value for each name,
// multiply this value by its alphabetical position in the list to obtain a name score.

//For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53,
// is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

// What is the total of all the name scores in the file?

namespace NamesScores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read string from file
            string inputNames = File.ReadAllText(@"names.txt");

            // Remove quotes from long string
            inputNames = Regex.Replace(inputNames, @"[\""]", "", RegexOptions.None);

            // Get list of names
            string[] names = inputNames.Split(',');

            // Sort list of names
            IEnumerable<string> listOfSortedNames =
                from name in names
                orderby name 
                select name;

            int positionInList = 0;
            long runningTotal = 0;

            foreach (string name in listOfSortedNames)
            {
                long nameSubTotal = 0;

                foreach(char letter in name)
                {
                    // Add value of each character to nameSubTotal
                    nameSubTotal += (int)letter - 64;
                }
                // Increment position in list
                positionInList++;

                // multiply by position in list
                runningTotal += (positionInList * nameSubTotal);
            }

            Console.WriteLine(runningTotal);

        }
    }
}
