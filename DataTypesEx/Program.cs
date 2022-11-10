using System;

namespace DataTypesEx
{
    internal class Program
    {
        //instance variable
        int num2;
        static int num3;
        public const int constVariable=45;
        readonly string city;
        static void Main(string[] args)
        {
            //Program.constVariable = 56;
            Program.num3 = 23;
            int a=Program.num3 = 34;
            Console.WriteLine(a);
            Program program = new Program();
            program.num2 = 23;
            Program program1 = new Program();
            program1.num2 = 34;

            //object or instance of class Add
            Add add=new Add();
            add.Addition();
            add.Subtraction();
            add.ParamaterizedMethod("Shweta Sapkal");
            add.ParamaterizedIntMethod(23,34);
            Console.WriteLine();
            Console.WriteLine("Parameter and return method addition is "+add.ParameterAndReturnMethod(30.33f,45.56f));

            Add.StaticMethod();
            
            
            //Console.WriteLine("Addition using return type is "+ add.AdditionReturnType());


            //DataTypes
            //int a = 34;
            //Console.WriteLine("integer value "+a);
            //int b = int.MaxValue;
            //Console.WriteLine("max value of int datatype " + b);
            //Console.WriteLine(byte.MaxValue);

            ////float double , decimal 
            //float f = 2334.45567f;
            //Console.WriteLine("float value is "+f);
            //Console.WriteLine(float.MinValue);

            //double d = 225667.78654321890;
            //Console.WriteLine("Double value is "+d);

            //decimal e = 12345.654321897654m;
            //Console.WriteLine("decimal value is "+e);

            ////bool  true false 
            //bool g = true;
            //int s = 23;
            //int h = 45;
            //bool c = s < h;
            //Console.WriteLine(c);

            ////string  multiple characters in single variable 
            ////char   single character
            //string name = "Shweta sapkal khghkgjh";
            //char ch = 'f';
            //Console.WriteLine("String values "+name);
            //Console.WriteLine("Char datatype value"+ch);
        }
    }
}
