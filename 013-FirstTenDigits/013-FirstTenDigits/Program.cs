using System;
using System.IO;
using System.Numerics;

namespace FirstTenDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = new BigInteger();
            
            StreamReader r = new StreamReader("testFile.txt");
            string line = r.ReadLine();

            while (line != null)
            {
                result += BigInteger.Parse(line);
                line = r.ReadLine();
            }
            r.Close();

            // Get first 10 characters of the result
            string firstTen = result.ToString().Substring(0, 10);
            Console.WriteLine("Answer = " + firstTen);
        }
    }
}
