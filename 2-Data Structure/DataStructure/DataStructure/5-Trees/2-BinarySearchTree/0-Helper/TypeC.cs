using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinarySearchTree.Helper
{
    class TypeC : BinarySearchTypes
    {
        public float Value { get; set; }
        public TypeC(int key, float value)
        {
            Key = key;
            Value = value;

        }
    }
}
