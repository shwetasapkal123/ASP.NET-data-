using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatckDemo
{
    public class QueueOperation
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        {
            Node newNode=new Node(data);

            if(rear==null)
            {
                rear=newNode;
                front = rear;
                //front=rear=newNode;
            }
            else
            {
                rear.next = newNode;
                rear=newNode;
            }
           // Console.WriteLine(data+" inserted into queue");
        }

        public void Display()
        {
            if(front==null)
            {
                Console.WriteLine("Queue is empty");
            }
            while(front!=null)
            {
                Console.WriteLine(front.data);
                front=front.next;
            }
        }

        public void Dequeue()
        {
            if(front==null)
            {
                Console.WriteLine("Empty");
            }
            Console.WriteLine("{0} is deleted from the queue", front.data);
            front = front.next;
        }
    }
}
