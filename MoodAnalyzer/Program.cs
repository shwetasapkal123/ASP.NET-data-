using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = "Shweta";
            TestException.TestArgumentNullException(name);
            TestException.TestArgumentOutOfRange(name);
        }
    }
}
