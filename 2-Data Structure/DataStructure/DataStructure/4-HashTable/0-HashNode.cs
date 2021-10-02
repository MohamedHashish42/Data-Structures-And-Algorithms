using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.HashTable
{
    class HashNode
    {
        public object Key { get; set; }
        public object Value { get; set; }

        public HashNode(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
