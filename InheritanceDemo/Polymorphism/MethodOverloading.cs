using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo.Polymorphism
{
    internal class MethodOverloading
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sum(int a, float b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum( float b,int a)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(int a, int b,int c)
        {
            Console.WriteLine(a + b);
        }
    }
}
