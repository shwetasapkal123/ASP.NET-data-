using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        //Advantages
        /*
         * increase reusability
         * typesafe
         * performance 
         * 
         */
        public static void ShowArray<T>(T[] inputArray)
        {
            foreach (T i in inputArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(typeof(T));
        }
        public static void Check<T> (T a)
        {
            Console.WriteLine(typeof(T));
        }
        //public static void ShowArray(float[] inputArray)
        //{
        //    foreach (float i in inputArray)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //public static void ShowArray(string[] inputArray)
        //{
        //    foreach (string i in inputArray)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        static void Main(string[] args)
        {
            // int[] intArray = { 1, 2, 3 };
            //// Program.ShowArray(intArray);

            // double[] floatArray = { 2.3, 5.7, 7.8, 12.45 };
            //// Program.ShowArray(floatArray);

            // string[] stringArray = { "Ravi", "Shweta", "Hema" };
            // //Program.ShowArray(stringArray);

            // Program.ShowArray<int>(intArray);
            // Program.ShowArray<double>(floatArray);
            // Program.ShowArray<string>(stringArray);

            // Program.Check(45);

            // Print<int> print = new Print<int>(intArray);
            // print.PrintArray();

            // Print<double> print1 = new Print<double>(floatArray);
            // print1.PrintArray();

            // Print<string> print2 = new Print<string>(stringArray);
            // print2.PrintArray();

            //int a = 10, b = 20, c = 30;
            //MaxNumber maxNumber = new MaxNumber();
            //// Console.WriteLine(maxNumber.PrintMaximumNumber(c,a, b)); 
            //int val = maxNumber.PrintMaximumNumber<int>(a, b, c);
            //Console.WriteLine("Max number is: "+val);
            Employee employee = new Employee()
            {
                name="rita",
                age=23,
                addr="Pune"
            };
            Employee employee2 = new Employee()
            {
                name = "Snehal",
                age = 23,
                addr = "Bengaluru"
            };
            Employee employee3 = new Employee()
            {
                name = "Smita",
                age = 25,
                addr = "Satara"
            };
            //list object
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(employee2);
            employees.Add(employee3);

            foreach(Employee ele in employees)
            {
                Console.WriteLine("Employee name is {0} age is {1} address is: {2} ",ele.name,ele.age,ele.addr);
            }



            List<int> list= new List<int> ();
            list.Add (11);
            list.Add (2);
            list.Add (30);
            list.Add(45);
            list.Add(45);
            list.Add(default);
            //list.Sort();
            //list.Contains (11);
            Console.WriteLine("capacity is "+list.Capacity);
            list.Add(66);
            Console.WriteLine("capacity is " + list.Capacity);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            //list.Add("dsg");

            List<string> list2 = new List<string>();
            list2.Add ("a");
            list2.Add ("b");
            list2.Add ("c");
            list2.Add(null);    //
            //list add nullable value
            //duplicate values add in the list
            Console.ReadLine();
        }
    }
}
