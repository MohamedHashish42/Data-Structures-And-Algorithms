using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{

    class StackUsingLinkedList<T>
    {
        public SLLNode<T> Top;
        public SLLNode<T> Bottom;
        public int Length;

        public StackUsingLinkedList()
        {
            Top = null;
            Bottom = null;
            Length = 0;
        }

        public T Peek()
        {
            if (Length > 0)
                return Top.Value;
            return default(T);
        }

        public void Push(T value)
        {
            SLLNode<T> newNode = new SLLNode<T>(value);
            if (Length == 0)
            {
                Top = newNode;
                Bottom = newNode;
            }
            else
            {
                SLLNode<T> holdingPointer = Top;
                Top = newNode;
                Top.Next = holdingPointer;
            }
            Length++;
        }

        public T Pop()
        {
            if (Top == null)
            {
                return default(T);
            }
            SLLNode<T> holdingPointer = Top;
            Top = Top.Next;
            Length--;
            return holdingPointer.Value;
        }


        public T ElementAt(int index)
        {
            int counter = 0;
            var currentNode = Top;
            while (counter != index)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode.Value;
        }


        public void Display()
        {
            if (Top == null)
            {
                return;
            }
            SLLNode<T> currentNode = Top;
            Console.Write(currentNode.Value);
            currentNode = currentNode.Next;
            while (currentNode != null)
            {
                Console.Write(" " + currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine("\n");
        }

    }
}
