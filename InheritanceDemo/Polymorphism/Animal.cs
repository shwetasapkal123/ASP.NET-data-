using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo.Polymorphism
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
}
