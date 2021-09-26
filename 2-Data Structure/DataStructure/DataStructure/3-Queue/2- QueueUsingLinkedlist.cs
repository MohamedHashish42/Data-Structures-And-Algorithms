using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{


    class QueueUsingLinkedlist<T>
    {
        public SLLNode<T> First;
        public SLLNode<T> Last;
        public int Length;

        public QueueUsingLinkedlist()
        {
            First = null;
            Last = null;
            Length = 0;
        }

        public T Peek()
        {
            if (Length > 0)
            {
                return First.Value;
            }
            return default(T);
        }

        public void Enqueue(T value)
        {
            SLLNode<T> newSLLNode = new SLLNode<T>(value);
            if (Length == 0)
            {
                First = newSLLNode;
                Last = newSLLNode;
            }
            else
            {
                Last.Next = newSLLNode;
                Last = newSLLNode;
            }
            Length++;
        }

        public T Dequeue()
        {
            if (First == null)
            {
                return default(T);
            }
            if (Length == 0)
            {
                Last = null;
            }
            SLLNode<T> holdingPointer = First;
            First = First.Next;

            Length--;

            return holdingPointer.Value;
        }

        public void Display()
        {
            if (First == null)
            {
                return;
            }
            SLLNode<T> currentSLLNode = First;
            Console.Write(currentSLLNode.Value);
            currentSLLNode = currentSLLNode.Next;
            while (currentSLLNode != null)
            {
                Console.Write(" " + currentSLLNode.Value);
                currentSLLNode = currentSLLNode.Next;
            }
            Console.WriteLine();
        }
    }
}
