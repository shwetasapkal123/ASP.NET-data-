using InheritanceDemo.Polymorphism;
using System;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           Maruti maruti = new Maruti();
             Car car = new Car();
            maruti.Model = "Alto";
            maruti.price = 200000;
            maruti.color = "Red";
            maruti.mileage = 22.5f;

            maruti.PrintCarInformation();
            maruti.PrintData();
            Bus bus = new Bus();
            bus.price = 8899;
            bus.mileage = 34.5f;

            MethodOverloading addition = new MethodOverloading();
            addition.Sum(12, 23.3f);

            Animal animal = new Animal();
            animal.Eat();
            Dog dog = new Dog();
            dog.Eat();
        }
    }
}
