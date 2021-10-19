using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinaryTree
{
    public class BTNode<T>
    {
        public T Value { get; set; }
        public BTNode<T>Left { get; set; }
        public BTNode<T> Right { get; set; }

        public BTNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
