using System;

namespace DS_StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack Operaions
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.IsEmpty();
            //Queue Operations
            QueueUsingLinkedList queue = new QueueUsingLinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
