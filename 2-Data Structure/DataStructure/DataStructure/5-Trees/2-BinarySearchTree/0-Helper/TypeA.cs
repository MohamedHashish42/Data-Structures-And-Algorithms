using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinarySearchTree.Helper
{
    class TypeA : BinarySearchTypes
    {
        public int Value { get; set; }
        public TypeA(int key, int value)
        {
            Key = key;
            Value = value;

        }
    }
}
