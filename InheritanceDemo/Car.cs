using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    internal class Car
    {
        public string Model;
        public string color;
        public int price;

        public void PrintCarInformation()
        {
            Console.WriteLine("Model: "+Model+"\tColur "+color+"\tprice "+price);
        }
    }

    class Maruti:Car
    {
        public float mileage;
        public void PrintData()
        {
            Console.WriteLine("Model: "+Model+"\tmileage "+mileage);
        }
    }
    class Bus:Maruti
    {
        public void NoOfWheels()
        {
            Console.WriteLine("six wheels");
        }

    }
}
