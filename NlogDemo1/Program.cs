using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            int firstNumber, secondNumber;
            Console.WriteLine("Enter first number");
            firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondNumber=Convert.ToInt32(Console.ReadLine());
            sum.Add(firstNumber,secondNumber);

            Console.ReadLine();
        }
    }
}
