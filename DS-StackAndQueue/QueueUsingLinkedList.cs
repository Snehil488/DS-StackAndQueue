using System;
using System.Collections.Generic;
using System.Text;

namespace DS_StackAndQueue
{
    class QueueUsingLinkedList
    {
        Node head;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while(n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
    }
}
