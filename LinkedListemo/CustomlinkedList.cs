using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListemo
{
    public class CustomlinkedList
    {
        Node head;

        public void AddEnd(int newData)
        {
            Node newNode=new Node(newData);

            if(this.head==null)
            {
                this.head=newNode;
            }
            else
            {
                Node temp = this.head;
                while(temp.next!=null)
                {
                    temp=temp.next;
                }
                temp.next=newNode;
            }

        }

        public void Display()
        {
            Node temp=this.head;
            if(temp==null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp=temp.next;
            }
        }

        public void Addfirst(int newData)
        {
            Node newnode=new Node(newData);
            newnode.next=head;
            this.head=newnode;
        }
    }
}
