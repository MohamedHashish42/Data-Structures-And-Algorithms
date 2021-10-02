using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.HashTable
{
    class HashtablePractices
    {
        public static void CsharpBuiltInHashtable()
        {
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add("First", "One");
            myHashtable.Add("Second", "Two");
            myHashtable.Add("Third", "Three");
            myHashtable.Add("Four", "Three");
            myHashtable.Add(9, "Nine");
            myHashtable.Remove(9);
            Console.WriteLine(myHashtable["Third"]);

            Display(myHashtable);



        }

        public static void CustomHashtableWithoutHandlingCollision()
        {
            CustomHashTable myHashtable = new CustomHashTable();
            myHashtable.Add("First", "One");
            myHashtable.Add("Second", "Two");
            myHashtable.Add("Third", "Three");
            myHashtable.Add("Four", "Three");
            myHashtable.Add(9, "Nine");
            //myHashtable.Add(8, "Eight");  //  will make collision with First because (First and 8) keys have the same hash which equals 6

            myHashtable.Remove(9);
            Console.WriteLine(myHashtable["Third"]);

            myHashtable.Display();

        }

        public static void Display(Hashtable hashTable)
        {
            foreach (DictionaryEntry de in hashTable)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            Console.WriteLine("\n\n");
        }


        public static void HandlingCollisionUsingSeparateChaining()
        {
            CustomHashTable2 myHashtable = new CustomHashTable2();
            myHashtable.Add(10, "Mohamed");
            myHashtable.Add(11, "Khalid");
            myHashtable.Add(12, "Mahmod");
            myHashtable.Add(13, "Ibrahim");
            myHashtable.Add(14, "Ali");
            myHashtable.Add(20, "Moaz");
            myHashtable.Remove(14);
            Console.WriteLine(myHashtable[20]);

            myHashtable.Display();

        }



    }
}
