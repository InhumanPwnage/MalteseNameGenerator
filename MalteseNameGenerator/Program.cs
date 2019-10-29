using System;
using System.IO;

namespace MalteseNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFirst = @"c:\maltese_first_male.txt";
            string pathSecond = @"c:\maltese_surnames.txt";

            try
            {
                var firstNames = File.ReadAllLines(pathFirst);
                var secondNames = File.ReadAllLines(pathSecond);

                Console.WriteLine("Loaded prefixes from: " + pathFirst);
                Console.WriteLine("Loaded suffixes from: " + pathSecond);

                Random r = new Random();

                Console.WriteLine($@"{firstNames[r.Next(0, firstNames.Length)]} {secondNames[r.Next(0, secondNames.Length)]}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadKey();
        }
    }
}
