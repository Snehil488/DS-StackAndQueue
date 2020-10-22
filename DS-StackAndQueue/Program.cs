using System;

namespace DS_StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}
