using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    //Derived or child class inherit from Animal Parent class
    public class Pig : Animal
    {
        public override void animalSound()
        {
            //Body of method(animalSound) declared here
            Console.WriteLine("The pig say Weeeeeeee Weeeeeeeee");
        }
    }
}
