using System;

namespace MSTestingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * AAA principle
             * arrange= initials inputs
             * Act= method
             * Assert= result occured 
             */
            Console.WriteLine("Hello World!");
            Add add = new Add();
            int res=add.SumOfNumbers(10, 20);
            Console.WriteLine(res);
        }
    }
}
