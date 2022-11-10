using System;

namespace DataTypesEx
{
    internal class Add
    {
        //instance variable
        public string Name;
        static string lastName;
        // method: define code once and use it multiple in the project
        //class : design/blueprint
        //object : instance of that class

        //Type of methods
        //1. access_modifier returnType MethodName()
        //{
        //  body/defination of method
        //}
        public void Addition()
        {
            int num1 = 23;
            int num2 = 34;
            int result=num1 + num2;
            Console.WriteLine("Addition is "+result);
        }
        public void Subtraction()
        {
            int num1 = 32;
            int num4 = 34;
            int result = num4 - num1;
            Console.WriteLine("Subtraction is " + result);
        }
        public int AdditionReturnType()
        {
            int num1 = 23;
            int num2 = 34;
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }
        //Paramaterized method
        public void ParamaterizedMethod(string msg)
        {
            Console.WriteLine("Hello "+msg);
        }
        public void ParamaterizedIntMethod(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition of paramerized int datatype method is "+result);
        }
        //Parameter and return method
        public float ParameterAndReturnMethod(float number1, float number2)
        {
            float result = number1 + number2;
            return result;
        }
        //static method
        public static void StaticMethod()
        {
            Console.WriteLine(" Static Method ");
        }
    }   
}
