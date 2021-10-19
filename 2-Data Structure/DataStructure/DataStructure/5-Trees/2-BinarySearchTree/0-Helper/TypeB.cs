using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinarySearchTree.Helper
{
    class TypeB : BinarySearchTypes
    {
        public string Value { get; set; }
        public TypeB(int key,string value)
        {
            Key = key;
            Value = value;
          
        }
    }
}
