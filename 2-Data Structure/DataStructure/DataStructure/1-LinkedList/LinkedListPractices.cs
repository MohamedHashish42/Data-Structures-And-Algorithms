using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    class LinkedListPractices
    {


        public static void CustomSingleLinkedList()
        {
            SingleLinkedList<string> sentence = new SingleLinkedList<string>();
            sentence.AddFirst("This");
            sentence.AddLast("Is");
            sentence.AddLast("Linked");
            sentence.AddLast("List");
            sentence.AddLast("Lesson");
            sentence.Remove(4);
            SLLNode<string> IsNode2 = sentence.Find(2);
            sentence.AddAfter(IsNode2, "The");
            sentence.Display();

            sentence.Reverse();
            sentence.Display();

        }

        public static void CsharpBuiltInDoublyLinkedList()
        {
            LinkedList<string> sentence = new LinkedList<string>();
            sentence.AddFirst("This");
            sentence.AddLast("Is");
            sentence.AddLast("Linked");
            sentence.AddLast("List");
            sentence.AddLast("Lesson");
            LinkedListNode<string> IsNode = sentence.Find("Is");
            sentence.AddAfter(IsNode, "The");
            Display(sentence);
        }


        public static void CustomDoublyLinkedList()
        {
            DoublyLinkedLists<string> sentence = new DoublyLinkedLists<string>();
            sentence.AddFirst("This");
            sentence.AddLast("Is");
            sentence.AddLast("Linked");
            sentence.AddLast("List");
            sentence.AddLast("Lesson");
            DLLNode<string> IsNode2 = sentence.Find("Is");
            sentence.AddAfter(IsNode2, "The");
            sentence.Display();

            //sentence.Reverse();
            //sentence.Display();

        }





        public static void Display<T>(LinkedList<T> linkedList)
        {

            foreach (T Item in linkedList)
            {
                Console.Write(Item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
