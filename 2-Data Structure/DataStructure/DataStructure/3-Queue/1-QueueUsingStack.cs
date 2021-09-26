using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{
    class QueueUsingStack<T>
    {
        private Stack<T> _PushStack = new Stack<T>();
        private Stack<T> _PopStack = new Stack<T>();

        public T Peek()
        {


            if (_PopStack.Count == 0)
            {
                var count = _PushStack.Count;
                for (int i = 0; i < count; i++)
                {
                    _PopStack.Push(_PushStack.Pop());
                }
            }
            if (_PopStack.Count > 0)
            {
                return _PopStack.Peek();
            }


            return default(T);
        }

        public void Enqueue(T value)
        {
            int count = _PopStack.Count;

            for (int i = 0; i < count; i++)
            {
                _PushStack.Push(_PopStack.Pop());
            }

            _PushStack.Push(value);

        }

        public T Dequeue()
        {

            int count = _PushStack.Count;
            for (int i = 0; i < count; i++)
            {
                _PopStack.Push(_PushStack.Pop());
            }

            return _PopStack.Pop();

        }

        public void Display()
        {

            if (_PopStack.Count == 0)
            {
                var count = _PushStack.Count;
                for (int i = 0; i < count; i++)
                {
                    _PopStack.Push(_PushStack.Pop());
                }
            }
            foreach (T Item in _PopStack)
            {
                Console.Write(Item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
