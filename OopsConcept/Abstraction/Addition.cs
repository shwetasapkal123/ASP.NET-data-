using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Abstraction
{
    public abstract class Addition
    {
        int a;
        //abstract method
        public abstract void AddTwoNumbers();
        //Concrete method 
        public void Sum()
        {
            Console.WriteLine("Sum method");
        }
    }

    public class AccessAdd:Addition
    {
        public override void AddTwoNumbers()
        {
            Console.WriteLine("Added two numbers");
        }
    }
}
