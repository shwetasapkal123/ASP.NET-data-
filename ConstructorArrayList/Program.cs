using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorArrayList
{
    public class Program
    {
        string CarModel;
        int Year; 
        public  Program(string model, int year)
        {
            //Console.WriteLine("Hello I am constructor");
            CarModel = model;
            Year = year;
            //this.CarModel = CarModel;
            //this.Year = Year;
        }
        public Program( int year, string model)
        {
            //Console.WriteLine("Hello I am constructor");
            CarModel = model;
            Year = year;
            //this.CarModel = CarModel;
            //this.Year = Year;
        }
        static Program()
        {
            Console.WriteLine("static constructor");
        }
        public Program()
        {
            Console.WriteLine("instance constructor");
        }
        static void Main(string[] args)
        {
            /*Constructor is special type of method 
             * to initialize variables or objects
             Properties:
                1. Same name as that of class
                2. do not have return Type (void , int , float ,double)
                3. Use access modifier
                4. Constructor invoked when object of that class is created
                5. It initializes member variables of class
                6. Overloaded overloaded.
            Type of constructors:
            1. Default Constructor: Compiler created
            2. User defined       : User/ Programmer created
            3. Paramaterized       : Pass parameter
            4. Static constructor
             */

            //Program program = new Program("Alto", 1967);
            //Program program1 = new Program(1984,"Mustang");
            //Program program1 = new Program();
            //program.CarModel = "Mustang";
            //program.Year = 1876;
            //Console.WriteLine("Model is "+program.CarModel+"  of the year: "+program.Year);

            //Program program = new Program();
            //Program program1 = new Program();
            //Program program2 = new Program();


            /*Array: Collection similar datatypes and index starts from zero
             * 
             
             */
            Console.WriteLine("%%%%%%%%%%%Declaration of array%%%%%%%%%%");
            int[] myarray = new int[4];
            myarray[0] = 11;
            myarray[1] = 22;
            myarray[2] = 33;
            myarray[3] = 44;
            Console.WriteLine(myarray[2]);
            string[] cars;
            string[] car2 = { "volvo","BMW","Alto","Ford"};
            cars = new string[] {"volvo","BMW" };
            Console.WriteLine("Printing array elements");
            //for loop
            //foreach
            for(int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }

            foreach(int element in myarray)
            {
                Console.WriteLine(element);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            Console.WriteLine("Capacity of arraylist is "+arrayList.Capacity);
            arrayList.Add(23.45);
            arrayList.Add('d');
            arrayList.Add("Shweta");
            Console.WriteLine("Capacity of arraylist is " + arrayList.Capacity);
            arrayList.Add(23);
            Console.WriteLine();
            Console.WriteLine("Index of char d is: "+arrayList.IndexOf('d') ); 
            Console.WriteLine("Capacity of arraylist is " + arrayList.Capacity);

            foreach(var ele in arrayList)
            {
                Console.WriteLine("Before inserting"+ele);
            }
            arrayList.Insert(2, "Ravi");
            arrayList.RemoveAt(2);
            arrayList.Remove(10);
            foreach (var ele in arrayList)
            {
                Console.WriteLine("After inserting"+ele);
            }
            Console.ReadLine();
        }
    }
}
