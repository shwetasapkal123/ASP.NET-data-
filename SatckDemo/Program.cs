using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatckDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Stack
            //Stack<int> listStack = new Stack<int>();
            //listStack.Push(1);
            //listStack.Push(2);
            //listStack.Push(3);
            //listStack.Push(4);

            //foreach (int i in listStack)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            ////Console.WriteLine(listStack.Peek());

            //Console.WriteLine("element deleted", listStack.Pop()); 
            //foreach (int i in listStack)
            //{
            //    Console.WriteLine(i);
            //}


            //StackOperations stack = new StackOperations();
            //stack.Push(11);
            //stack.Push(12);
            //stack.Push(13);

            //Console.WriteLine();
            //Console.WriteLine();
            //stack.Peek();


            //stack.Display();

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //foreach(int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //queue.Dequeue();
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            QueueOperation queue=new QueueOperation();
            queue.Enqueue(22);
            queue.Enqueue(44);
            queue.Enqueue(88);

            queue.Dequeue();
            queue.Display();
            Console.ReadLine();
        }
    }
}
