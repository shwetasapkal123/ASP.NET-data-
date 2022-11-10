using System;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double Fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Total fare is " + Fare);
        }
    }
}
