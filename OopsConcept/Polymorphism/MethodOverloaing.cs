using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism
{
    internal class MethodOverloaing
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Addition is "+a+b);
        }
        public void Sum(float a, int b)
        {
            Console.WriteLine("Addition is " + a + b);
        }
        public void Sum(int a, int b,float c)
        {
            Console.WriteLine("Addition is " + a + b);
        }
        public void Sum(int a, float c,int b)
        {
            Console.WriteLine("Addition is " + a + b);
        }
        public void Sum(int a, float b)
        {
            Console.WriteLine("Addition is " + a + b);
        }
        public void Sum(float b,float a)
        {
            Console.WriteLine("Addition is " + a + b);
        }
    }
}
