using System;
using System.Collections.Generic;
using System.Text;

namespace DS_StackAndQueue
{
    class StackUsingLinkedList
    {
        Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.WriteLine(node.data + " pushed to Stack");
        }
        public void Pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine(top.data+" popped from Stack");
                top = top.next;
            }
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine(top.data + " is at top of Stack");
            }
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node n = top;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
        public void IsEmpty()
        {
            while(top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty now.");
        }

    }
}
