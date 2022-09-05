using OOPS.Abstraction;
using OOPS.Constructor;
using OOPS.Encapsulation;
using OOPS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Hello i am constructor");
        }
        //Abstract class
            //abstract class Animal
            //{
            //    //abstract method(does not have body)
            //    public abstract void animalSound();
            //    //common method
            //    public void sleep()
            //    {
            //        Console.WriteLine("Zzzzz"); 
            //    }
            //}
            //To remove error of object creation of abstract class
            //Use inheritance and override keyword
        abstract class Animal
        {
            //abstract method(does not have body)
            public abstract void animalSound();
            //common method
            public void sleep()
            {
                Console.WriteLine("Zzzzz");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            /* OOPS have 6 key concepts
             1.Class:   Blueprint of an object that contains variables for storing data,functions to perform operation
            2.Object:   is an instance of class.it is software bundle of related variable and methods
            3.Abstraction   :
            4.Encapsulation
            5.Inheritance
            6.Polymorphism*/

            //*************Abstraction class*************//
            // Animal animal = new Animal();   //give an error

            //Solving above object error
            //Create object of child class
            Pig pig = new Pig();
            //Calling abstract method
            pig.animalSound();
            //Calling common method
            pig.sleep();
            //we can create multiple objects
            Pig pig2 = new Pig();
            pig2.animalSound();
            pig2.sleep();

            //################## Encapsulation#################//
            Account account = new Account();
            account.Eat();
            Encapsulation.Dog dog = new Encapsulation.Dog();
            dog.Eat();


            //************************Interface*****************//
            //Dog dog = new Dog();
            //dog.AnimalSound();

            Lion lion = new Lion();
            lion.AnimalSound();

            Tiger tiger = new Tiger();
            tiger.AnimalSound();

            //using abstract
            Dog2 dog2 = new Dog2();
            dog2.AnimalSound2();

            //#######################Constructor###########################//
            ConstructorType constructorType = new ConstructorType();

            //When we called object multiple times then static constructor called once and
            //instance constructor called how many times object clled
            ConstructorType constructorType1 = new ConstructorType();
            ConstructorType constructorType2 = new ConstructorType();
            ConstructorType constructorType3 = new ConstructorType();

            Console.ReadLine();

        }
    }
}
