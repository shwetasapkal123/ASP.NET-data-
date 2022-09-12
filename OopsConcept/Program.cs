using OopsConcept.Abstraction;
using OopsConcept.Encapsulation;
using OopsConcept.Interface;
using OopsConcept.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Run();
            //car.colur = "Pink";
            //car.wheels = 4;
            //car.CarRun();


            //vehicle vehicle = new vehicle();
            //vehicle.Run();
            //vehicle.colur = "Red";
            //vehicle.wheels = 2;
            Console.WriteLine("#############Method overriding##################");
            Animal animal = new Animal();
            animal.Eat();
            Dog dog = new Dog();
            dog.Eat();
            Console.WriteLine("#############Method overloading##################");
            MethodOverloaing methodOverloaing = new MethodOverloaing();
            methodOverloaing.Sum(12,34);
            methodOverloaing.Sum(12.56f,45);

            Console.WriteLine("#############Encapsulation##################");
            Account account = new Account();
            //account.SetBalance(10000);
            //account.GetBalance();
            account.AccountBalance = 10000;
            Console.WriteLine("Your account balance is "+account.AccountBalance);

            Console.WriteLine("##################Abstraction");
           // Addition addition = new Addition();
           AccessAdd accessAdd=new AccessAdd();
            accessAdd.AddTwoNumbers();
            accessAdd.Sum();

            Console.WriteLine("%%%%%%%%%%%%%interface%%%%%%%%%%%%%%");
            //IAddition addition = new IAddition();
            //Demo demo = new Demo();
            //demo.AddTwoNumber();
            
            ISubtract demo1 = new Demo();
            demo1.AddTwoNumber();

            IAddition demo2=new Demo();
            demo2.AddTwoNumber();

            Console.ReadLine();
        }
    }
}
