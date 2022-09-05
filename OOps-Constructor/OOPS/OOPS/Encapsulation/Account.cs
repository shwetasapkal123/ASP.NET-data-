using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Encapsulation
{
    public class Account
    {
        public virtual void Eat()
        {
            
            Console.WriteLine("Animal is eating");
           
        }
    }
    public class Dog:Account
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
}
