using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.Stack
{
    class StackPractices
    {
        public static void CsharpBuiltInStack()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Pop();
            Console.WriteLine("Element At 0 = " + myStack.ElementAt(0));
            Console.WriteLine("Peek = " + myStack.Peek());
            Display(myStack);
        }


        public static void CustomStackUsingLinkedList()
        {
            StackUsingLinkedList<int> myStack = new StackUsingLinkedList<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Pop();
            Console.WriteLine("Element At 0 = " + myStack.ElementAt(0));
            Console.WriteLine("Peek = " + myStack.Peek());
            myStack.Display();
        }


        public static void CustomStackUsingList()
        {
            StackUsingList<int> myStack = new StackUsingList<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Pop();
            Console.WriteLine("Peek = " + myStack.Peek());
            myStack.Display();
        }


        public static void Display<T>(Stack<T> stack)
        {
            foreach (T Item in stack)
            {
                Console.Write(Item + " ");
            }
            Console.WriteLine("\n");

        }
    }
}
