using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(56);
            stack.Push(50);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();

            LinkeListQueue queue = new LinkeListQueue();
            queue.Enqueue(70);
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Display();
        }

        //BST - Binary Search Tree
        //Delegates
    }
}
