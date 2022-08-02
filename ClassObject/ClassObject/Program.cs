using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    public class Program
    {
        /* declaring instance variables 
         there are different types of variables we can learn it later or you can google it */
        int num1;
        int num2;
        int result;
        static void Main(string[] args)
        {
            /*here i am declaring only welcome msg and run the code it only give me welcome as a output 
             it does not show addidtion subtraction bcz we did not declare addition method in main method */
            Console.WriteLine("Welcome");  
            // now we declare object of the program class new keyword use here to declare object
            //Program is class name
            //program is reference object name
            //Program() is constructor create  ......constructor we will see later in deep
            Program program = new Program();
            //initializing the values hardcoted values
            program.num1 = 10;
            program.num2 = 20;
            //we can take values from users also
            //here i am just giving msg from that user can understand we have to enter number
            Console.WriteLine("Enter first num: ");
            //reading the value ..in c# all the input data in string only so here we convert 
            //value to integer value and srored that value in num1 variable
            program.num1 = Convert.ToInt32(Console.ReadLine());
            //same for num2 also
            Console.WriteLine("Enter second num: ");
            program.num2 = Convert.ToInt32(Console.ReadLine());
            //Calling methods of program class
            program.Addition();
            program.Subtraction();





            /* we can create another class of calculatorMethod and under that we can declare methods and variables
             * and call that class in program main class lets see how to create class and object by another way*/
            // calling the class and creating object of the class
            CalculatorMethods calculatorMethods = new CalculatorMethods();
            //here we can access only Addition method WHY???
            //bcz we declare addition method as public we can see access modifiers later
            //so make substraction method as public then we got access of subtraction method
            calculatorMethods.Addition();

            //these console readline is used to hold the run window 
            Console.ReadLine();
        }
        //declaring methods or operations that we want to perform on variables

       public void Addition()
        {
            //add num1 variable with num2 variable and store result in result variable
            result=num1+ num2;
            //print the output
            //we can print output in two ways 1st by decalring {0} and assigned that {0} value as result
            //like that we can declare {1} {2} in sequence and assign value for example here i will also print num1 and num2 value
            Console.WriteLine("Addition of {0}+{1} is {2}",num1,num2,result);
            //you can change the sequence also 
            Console.WriteLine("Addition of {0}+{1} is {2}", num2,num1,result);
            //second method of declaration we will use in substraction method
            Console.WriteLine("Addition is {0} ",result);
        }
        void Subtraction()
        {
            //performing subtraction on num1 and num2 variables and store result of sub in result variable
            result =num1- num2;
            //now for printing we print directly by using these + sign 
            Console.WriteLine("Subtraction is "+result);
            //or without giving msg directly we can print output
            Console.WriteLine(result);
        }
    }
}
