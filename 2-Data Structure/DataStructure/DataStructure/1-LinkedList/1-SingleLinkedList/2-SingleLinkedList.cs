using System;

namespace DataStructure.LinkedList
{

    public class SingleLinkedList<T>
    {
        private SLLNode<T> Head;
        private SLLNode<T> Tail;
        private int Length;
        public int getLength()
        {
            return Length;
        }

        public SLLNode<T> getHead()
        {
            return Head;
        }

        public SLLNode<T> getTail()
        {
            return Tail;
        }
        public SingleLinkedList()
        {
            Length = 0;
        }


        public void AddFirst(T value)   // In some language called (prepend)
        {

            var newNode = new SLLNode<T>(value);
            newNode.Next = Head;
            Head = newNode;

            if (Length == 0)
            {
                Tail = Head;
            }
            Length++;
        }

        public void AddLast(T value)    // In some language called (append)
        {
            var newNode = new SLLNode<T>(value);
            Tail.Next = newNode;
            Tail = newNode;
            if (Length == 0)
            {
                Head = Tail;
            }
            Length++;
        }


        public void AddAfter(SLLNode<T> Node, T value)
        {
            if (Node != null)
            {
                var newNode = new SLLNode<T>(value);
                var holdingPointer = Node.Next;
                Node.Next = newNode;
                newNode.Next = holdingPointer;
                Length++;
            }
            else
            {
                Console.WriteLine("The Node You Passed Not Exist");
            }
        }

        public void Remove(int index)
        {

            var UnWantedNode = Find(index);
            var PrevOfUnWantedNode = Find(index - 1);

            if (PrevOfUnWantedNode != null)
            {
                PrevOfUnWantedNode.Next = UnWantedNode.Next;
                Length--;
            }
            else
            {
                Console.WriteLine("The Value You Passed Not Exist");
            }
        }


        public SLLNode<T> Find(int index)
        {
            int counter = 0;
            var currentNode = Head;
            while (counter != index)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode;
        }


        public void Reverse()
        {
            SLLNode<T> first = Head;
            Tail = Head;
            
            SLLNode<T> second = first.Next;
            while (second != null)
            {
                SLLNode<T> temp = second.Next;
                second.Next = first;
                first = second;
                second = temp;
            }
            Head.Next = null;//because head become tail
            Head = first;
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

