using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddLast(1);
            //list.AddLast(2);
            //list.AddLast(3);

            //foreach(int ele in list)
            //{
            //    Console.WriteLine(ele);
            //}
            //Console.WriteLine("###########");
            //Console.WriteLine();
            //LinkedList<int> list2 = new LinkedList<int>();
            //list2.AddFirst(1);
            //list2.AddFirst(2);
            //list2.AddFirst(3);
            //foreach (int ele in list2)
            //{
            //    Console.WriteLine(ele);
            //}

            CustomlinkedList customlinkedList = new CustomlinkedList();
            customlinkedList.AddEnd(11);
            customlinkedList.AddEnd(12);
            customlinkedList.AddEnd(13);    
            customlinkedList.AddEnd(14);
            Console.WriteLine("Element added after head node");
            customlinkedList.Display();

            CustomlinkedList customlinkedList1 = new CustomlinkedList();
            customlinkedList1.Addfirst(11);
            customlinkedList1.Addfirst(12);
            customlinkedList1.Addfirst(13);

            Console.WriteLine();
            Console.WriteLine("Element added before the head node");
            customlinkedList1.Display();

            /*
             * head=0 null
             * head =11 null
             * head 11 add(12)
             * 
             * node1 12 null
             * node1 12 add(13)
             * 
             * node2 13 null
             */
            Console.ReadLine();
        }
    }
}
