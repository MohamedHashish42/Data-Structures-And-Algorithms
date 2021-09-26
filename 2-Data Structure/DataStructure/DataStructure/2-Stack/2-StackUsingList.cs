using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{

    class StackUsingList<T>
    {
        private List<T> _list;

        public StackUsingList()
        {
            _list = new List<T>();

        }

        public T Peek()
        {
            if (_list.Count > 0)
                return _list[_list.Count - 1];
            return default(T);
        }

        public void Push(T value)
        {
            _list.Add(value);
        }

        public T Pop()
        {
            if (_list.Count == 0)
            {
                return default(T);
            }
            T lastItem = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return lastItem;
        }

        public void Display()
        {

            foreach (var item in _list)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine("\n");
        }

    }
}
