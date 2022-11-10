using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program.doListDemo();
            doStackDemo();
            doQueuedemo();
            doSetDemo();
            doDictionaryDemo();
            Stack stack=new Stack();
            
        }
        private static void doListDemo()
        {
            Console.WriteLine("\n IN doListDemo ");

            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\n IN doStackDemo ");

           Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvi");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop=stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Popped element: "+pop);
        }
        private static void doQueuedemo()
        {
            Console.WriteLine("\n In do Queue Demo");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay raj");
            queue.Enqueue("Raj");

            Console.WriteLine("Head: "+queue.Peek());

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\n In set Demo ");

            HashSet<string> set=new HashSet<string>();
            set.Add("Ravi");
            set.Add("vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            foreach(var item in set)
            {
                Console.WriteLine(item);
            }
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\n In dictionary demo");
            Dictionary<int,string> dictionary=new Dictionary<int,string>();
            dictionary.Add(101, "Amit");
            dictionary.Add(102, "Rahul");
            dictionary.Add(103, "vijay");

            Console.WriteLine("Access value using key: " + dictionary[102]);

            foreach(var item in dictionary)
            {
                Console.WriteLine("key: "+item.Key+"  "+" value: "+item.Value);
            }
        }
    }
}
