using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.HashTable
{


    class CustomHashTable
    {

        Dictionary<object, HashNode> data;

        public CustomHashTable()
        {
            data = new Dictionary<object, HashNode>();
        }
        private int Hash(object key)
        {
            var keytoString = key.ToString();
            int hash = 0;
            for (int i = 0; i < keytoString.Length; i++)
            {
                hash = hash * 15 + (int)keytoString[i];
            }
            hash = hash % 10;
            return hash;

        }
        public object this[object key]
        {
            get
            {

                int hashKey = Hash(key);
                try
                {
                    return data[hashKey].Value;
                }

                catch (Exception)
                {

                    Console.WriteLine("This key (" + key + ") is not exist");
                    return null;
                }
            }

        }



        public void Add(object key, object value)
        {

            int hashKey = Hash(key);
            try
            {
                data.Add(hashKey, new HashNode(key, value));
            }

            catch
            {
                Console.WriteLine("This key is used before");
                return;
            }

        }

        public void Remove(object key)
        {
            int hashKey = Hash(key);
            try
            {
                data.Remove(hashKey);
            }

            catch
            {
                Console.WriteLine("This key is not exist");
                return;
            }
        }


        public List<string> keys()
        {
            List<string> result = new List<string>();
            foreach (var item in data)
            {
                result.Add(item.Key.ToString());
            }

            return result;
        }



        public void Display()
        {
            foreach (var obje in data)
            {
                Console.WriteLine("Key: {0}, Value: {1}", obje.Value.Key, obje.Value.Value);
            }

            Console.WriteLine("\n\n");
        }
    }
}