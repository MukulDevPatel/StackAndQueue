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
        }

        //BST - Binary Search Tree
        //Delegates
    }
}
