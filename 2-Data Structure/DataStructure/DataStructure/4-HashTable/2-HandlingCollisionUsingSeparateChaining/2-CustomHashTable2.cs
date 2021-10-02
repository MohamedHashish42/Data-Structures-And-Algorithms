using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.HashTable
{


    class CustomHashTable2
    {

        Dictionary<object, LinkedList<HashNode>> data;

        public CustomHashTable2()
        {
            data = new Dictionary<object, LinkedList<HashNode>>();
        }
        private int Hash(object key)
        {
            var keytoString = key.ToString();
            int hash = 0;
            Int32.TryParse(keytoString, out hash);
            if (hash != 0)
                return hash % 10;


            for (int i = 0; i < keytoString.Length; i++)
            {
                hash = hash +15* (int)keytoString[i];
            }
            hash = hash % 10;
            return hash;

        }



        public object this[object key]
        {
            get
            {
                int hashKey = Hash(key);
                if (data.ContainsKey(hashKey))
                {
                    foreach (var hashNode in data[hashKey])
                    {
                        if (hashNode.Key.Equals(key))
                            return hashNode.Value;
                    }
                }
                Console.WriteLine("This key (" + key + ") is not exist");
                return null;
            }

        }





        public void Add(object key, object value)
        {


            if (Keys().Contains(key.ToString()))
            {
                Console.WriteLine("This key is used before");
                return;
            }


            //If Collision Exists         
            int hashKey = Hash(key);
            if (data.Keys.Contains(hashKey))
            {
                foreach (var item in data)
                {
                    if (item.Key.Equals(hashKey))
                    {
                        data[hashKey].AddLast(new HashNode(key, value));
                        return;
                    }
                }
            }



            var listOfHashNode = new LinkedList<HashNode>();
            listOfHashNode.AddLast(new HashNode(key, value));
            data.Add(hashKey, listOfHashNode);

        }

        public void Remove(object key)
        {


            int hashKey = Hash(key);
            try
            {
                if (data[hashKey].Count == 1)
                {
                    data.Remove(hashKey);
                    return;
                }


                //If Collision Exist
                foreach (var item in data[hashKey])
                {
                    if (item.Key.Equals(key))
                    {
                        var nodeToRemove = data[hashKey].SingleOrDefault(a => a.Key.Equals(key));
                        if (nodeToRemove != null)
                        {
                            data[hashKey].Remove(nodeToRemove);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("This key is not exist");
                return;
            }
        }




        public List<string> Keys()
        {
            List<string> result = new List<string>();
            foreach (var item in data)
            {
                foreach (var hashNode in item.Value)
                {
                    result.Add(hashNode.Key.ToString());
                }
            }
            return result;
        }


        public void Display()
        {
            foreach (var item in data)
            {
                foreach (var hashNode in item.Value)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", hashNode.Key, hashNode.Value);
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}