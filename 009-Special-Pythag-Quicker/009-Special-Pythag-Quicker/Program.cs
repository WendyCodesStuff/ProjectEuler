using System;

namespace Special_Pythag_Quicker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            PrintTriplet();
            DateTime end = DateTime.Now;
            Console.WriteLine("Time Taken: " + (end-start).TotalSeconds.ToString() + " seconds");
        }

        static void PrintTriplet()
        {
            for (long c = 1; c <= 1000; c++)
            {
                long cc = c * c;
                for (long a = 1; a <= (1000 - c); a++)
                {
                    long aa = a * a;
                    long b = 1000 - c - a;
                    if (b > 0)
                    {
                        // if a^2 + b^2 = c^2
                        if ((aa) + (b * b) == (cc))
                        {
                            //if (a + b + c == 1000)
                            //{
                                Console.WriteLine("Product " + a + " * " + b + " * " + c + " = " + (a * b * c));
                                return;
                            //}
                            //else
                            //{
                            //    if (a + b + c > 1000)
                            //        break;
                            //}
                        }
                    }
                   
                }
            }
        }
    }
}
