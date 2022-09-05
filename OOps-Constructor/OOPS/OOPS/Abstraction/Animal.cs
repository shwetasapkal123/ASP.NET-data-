using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    /* To remove error of object creation Add override keyword in child class and interitance*/
    //Parent Class
    public abstract class Animal
    {
        //abstract method(does not have body)
            public abstract void animalSound();
        //common method
        public void sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }
}
