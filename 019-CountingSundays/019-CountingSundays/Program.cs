using System;

//You are given the following information, but you may prefer to do some research for yourself.

//1 Jan 1900 was a Monday.
//Thirty days has September,
//April, June and November.
//All the rest have thirty-one,
//Saving February alone,
//Which has twenty-eight, rain or shine.
//And on leap years, twenty-nine.
//A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
//How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

namespace CountingSundays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime finalDate = new DateTime(2000, 12,31);
            DateTime thisDate = new DateTime(1901, 1, 1);
            long totalSundays = 0;

            // See if 1-1-1901 is a Sunday
            //if (IsSunday(thisDate))
            //    totalSundays++;

            // Check first of every month
            while (thisDate.CompareTo(finalDate) < 1)  // until 31-12-2000
            {
       
           

                if (IsSunday(thisDate))
                    totalSundays++;

                // Next first of the month
                thisDate = thisDate.AddMonths(1);

            }

            Console.WriteLine("Number of Sundays in the 20th Century: " + totalSundays);
        }

        static bool IsSunday(DateTime testDate)
        {
            // 31 Dec 1899 was a Sunday, so find the number of days difference.
            DateTime aSunday = new DateTime(1899, 12, 31);
            int days = (testDate - aSunday).Days;

            // If divisible by 7 then it's a Sunday
            return (days % 7 == 0);
            
        }
    }
}
