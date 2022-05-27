using System;

namespace Day_16_exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
