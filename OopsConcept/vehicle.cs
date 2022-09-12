using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class vehicle    //A
    {
        public string colur;
        public int wheels;

        public void Run()
        {
            Console.WriteLine("Vehicle is in running mode");
        }
    }
    public class Car:vehicle    //B
    {
        public void CarRun()
        {
            Console.WriteLine("Car is in running mode");
        }
    }
    public class Bus:vehicle    //c
    {
        public void BusRun()
        {
            Console.WriteLine("Bus is in running");
        }
    }
    

}
