using System;

namespace DataStructure.LinkedList
{

    public class DoublyLinkedLists<T>
    {
        private DLLNode<T> Head;
        private DLLNode<T> Tail;
        private int Length;
        public int getLength()
        {
            return Length;
        }

        public DLLNode<T> getHead()
        {
            return Head;
        }

        public DLLNode<T> getTail()
        {
            return Tail;
        }
        public DoublyLinkedLists()
        {
            Length = 0;
        }


        public void AddFirst(T value)   // In some language called (prepend)
        {

            var newNode = new DLLNode<T>(value);
            newNode.Next = Head;
            newNode.Previous = null;

            if (Head != null)
                Head.Previous = newNode;

            Head = newNode;

            if (Length == 0)
            {
                Tail = Head;
            }

            Length++;

        }



        public void AddLast(T value)    // In some language called (append)
        {
            var newNode = new DLLNode<T>(value);
            newNode.Previous = Tail;
            newNode.Next = null;

            if (Length == 0)
            {
                Head = Tail;
            }

            if (Tail != null)
                Tail.Next = newNode;

            Tail = newNode;



            Length++;
        }


        public void AddAfter(DLLNode<T> node, T value)
        {
            if (node != null)
            {
                var newNode = new DLLNode<T>(value);
                var holdingPointerToNext = node.Next;

                node.Next = newNode;
                newNode.Previous = newNode;

                newNode.Next = holdingPointerToNext;
                holdingPointerToNext.Previous = newNode;


                newNode.Previous = node;
                Length++;
            }
            else
            {
                Console.WriteLine("The Node You Passed Not Exist");
            }
        }

        public void Remove(T value)
        {

            var UnWantedNode = Find(value);

            if (UnWantedNode != null)
            {
                var nextOfUnWantedNode = UnWantedNode.Next;
                var PrevOfUnWantedNode = UnWantedNode.Previous;
                PrevOfUnWantedNode.Next = nextOfUnWantedNode;
                Length--;
            }
            else
            {
                Console.WriteLine("The Value You Passed Not Exist");
            }
        }

        public DLLNode<T> Find(T value)
        {
            int counter = 0;
            var currentNode = Head;
            while (!currentNode.Value.Equals(value))
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode;
        }
        public void Reverse()
        {
            DLLNode<T> first = Head;
            Tail = Head;

            DLLNode<T> second = first.Next;
            while (second != null)
            {
                DLLNode<T> temp = second.Next;
                second.Next = first;
                first.Previous = second;

                first = second;
                second = temp;
            }

            Head.Next = null;//because head become tail
            Head = first;
            Head.Previous = null;
        }

        public void Display()
        {
            if (Head == null)
            {
                return;
            }
            var current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}

