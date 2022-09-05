using System;
using System.Collections;

namespace ArrayExplanation
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //Array:Collection of similar datatypes And index starts from zero
            //create array of 3 elements
            int[] myArray = new int[3];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            //  myArray[3] = 4; //Exception Comes bcz array size is 3

            //############Array Printing methods#######################
            //1.Using for loop
            //2.Using Foreach
            Console.WriteLine("\t\tPrinting array using For Loop");
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\t\tPrint array using foreach");
            //these we can use only with arrays and lists collections
            foreach(int i in myArray)
            {
                Console.WriteLine(i);
            }

            //#############Array Declarations ###########################//
            //Declare array
            string[] cars;
            //array with adding values without new keyword
            string[] cars2 = { "volvo", "BMW", "Ford" };

            //array values using new 
            cars = new string[] { "volvo", "BMW", "Ford" };
            int[] cars3 = { 1, 2, 3 };

          ArrayList arrayList = new ArrayList();
            Console.WriteLine("capacity is " + arrayList.Capacity);
            arrayList.Add(10);
            //capacity tells number of items 
            Console.WriteLine("capacity is "+arrayList.Capacity);
            arrayList.Add("Shital");
            Console.WriteLine("capacity is " + arrayList.Capacity);
            arrayList.Add(23.45);
            Console.WriteLine("capacity is " + arrayList.Capacity);
            arrayList.Add(30);
            arrayList.Add(40);
            arrayList.Add(50);
            Console.WriteLine("capacity is " + arrayList.Capacity);
            Console.WriteLine("\t\tprint arraylist");
            foreach(var i in arrayList)
            {
                Console.WriteLine(i);
            }

            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%Insert in the arraylist%%%%%%%%%%%%%%%%%%%%%//
            //index number and value....here 2 is index an shweta is value
            //at the 2nd position it will add shweta
            //these will not do with array
            arrayList.Insert(2, "Shweta");
            Console.WriteLine("\t\t\tArray list after inserting element");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            //we can also remove element from list
            arrayList.RemoveAt(2);
            arrayList.Remove(10);
            Console.WriteLine("Removed element");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ Arraylist constructors $$$$$$$$$$$$$$$$$$$$$//
            //1.default constructor
            //2. constructors under that we can declsre initial capacity
            //e.g. new Arraylist() ...........Arraylist() is constructor ...default constructor
            ArrayList arrayList2 = new ArrayList(2);    //Arraylist(2) is constructor under i declared capacity 2
                                                        //means capacity start from 2 after 2 element it gets double
            arrayList2.Add(10);
            arrayList2.Add(20);
            Console.WriteLine("capacity is :"+arrayList2.Capacity);
            //after 3rd element capacity gets double
            arrayList2.Add(40);
            Console.WriteLine("capacity is: "+arrayList2.Capacity);

        }
    }
}
