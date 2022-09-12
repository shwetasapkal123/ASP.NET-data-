using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism
{
    internal class PolyEx
    {
        //Two types
        //1.RunTime    e.g. method overriding
        //2.Compile time  e.g. method overloading

        //Example of plus operator
        public void Example()
        {
            //+ is used for addition operation
            int res = 10 + 20;
            Console.WriteLine("Hello "+" "+"Everyone");
        }
        public void Example2()
        {
            //+ is used for string concatenation
            Console.WriteLine("Hello " + " " + "Everyone");
        }
        
        /*
         * method overloading
         * 1. All methods should have same name
         * 2. methods in one class
         * 3. different parameter 
         */
    }
}
