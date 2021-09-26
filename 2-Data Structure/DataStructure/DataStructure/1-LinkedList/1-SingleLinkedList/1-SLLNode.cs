using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    public class SLLNode<T>
    {
        public T Value { get; set; }
        public SLLNode<T> Next { get; set; }

        public SLLNode(T value)
        {
            Value = value;
        }
    }

}
