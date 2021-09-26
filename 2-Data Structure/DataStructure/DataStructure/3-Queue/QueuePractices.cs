using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{
    class QueuePractices
    {
        public static void CsharpBuiltInQueue()
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Dequeue();
            myQueue.Enqueue(4);
            Console.WriteLine("Peek = " + myQueue.Peek());
            Display(myQueue);
        }


        public static void CustomQueueUsingStack()
        {
            QueueUsingStack<int> myQueue = new QueueUsingStack<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Dequeue();
            myQueue.Enqueue(4);
            Console.WriteLine("Peek = " + myQueue.Peek());
            myQueue.Display();
        }

        public static void CustomQueueUsingLinkedlist()
        {
            QueueUsingLinkedlist<int> myQueue = new QueueUsingLinkedlist<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Dequeue();
            myQueue.Enqueue(4);
            Console.WriteLine("Peek = " + myQueue.Peek());
            myQueue.Display();
        }





        public static void Display<T>(Queue<T> queue)
        {
            foreach (T Item in queue)
            {
                Console.Write(Item + " ");
            }
            Console.WriteLine("\n");

        }


    }
}
