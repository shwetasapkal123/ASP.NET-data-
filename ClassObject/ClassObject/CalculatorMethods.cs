using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    internal class CalculatorMethods
    {
        int num1;
        int num2;
        int result;
        public void Addition()
        {
            //add num1 variable with num2 variable and store result in result variable
            result = num1 + num2;
            //print the output
            //we can print output in two ways 1st by decalring {0} and assigned that {0} value as result
            //like that we can declare {1} {2} in sequence and assign value for example here i will also print num1 and num2 value
            Console.WriteLine("Addition of {0}+{1} is {2}", num1, num2, result);
            //you can change the sequence also 
            Console.WriteLine("Addition of {0}+{1} is {2}", num2, num1, result);
            //second method of declaration we will use in substraction method
            Console.WriteLine("Addition is {0} ", result);
        }
        void Subtraction()
        {
            //performing subtraction on num1 and num2 variables and store result of sub in result variable
            result = num1 - num2;
            //now for printing we print directly by using these + sign 
            Console.WriteLine("Subtraction is " + result);
            //or without giving msg directly we can print output
            Console.WriteLine(result);
        }
    }
}
