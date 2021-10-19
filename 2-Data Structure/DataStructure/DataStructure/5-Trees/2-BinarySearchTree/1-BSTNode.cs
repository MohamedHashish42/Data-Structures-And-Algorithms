using DataStructure.Trees.BinarySearchTree.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinarySearchTree
{
    public class BSTNode<T> where T: BinarySearchTypes
    {
        public T Obj { get; set; }
        public BSTNode<T> Left { get; set; }
        public BSTNode<T> Right { get; set; }
        public BSTNode()
        {

        }
        public BSTNode(T obj)
        {
            Obj = obj;
            Left = null;
            Right = null;
        }
    }
}
