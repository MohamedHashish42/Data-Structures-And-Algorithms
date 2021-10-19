using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinaryTree
{
 
    public class BinaryTree<T>
    {

        public BTNode<T> root { get; set; }

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T value)
        {
            root = new BTNode<T>(value);
        }

    }
}
