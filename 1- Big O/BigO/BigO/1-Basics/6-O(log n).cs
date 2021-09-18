using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }


    class BinarySearchTree
    {
        public Node Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            var newNode = new Node(value);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            var current = Root;
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    }
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    }
                    current= current.Right;
                }
            }
          
        }


        public Node Search(int value)
        {
            if (Root == null)
            {
                return null;
            }
            Node currentNode = Root;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if (value > currentNode.Value)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    return currentNode;
                }
            }
            return null;
        }

        
        public void printTree()
        {
            print2DUtil(Root, 0);
        }

        private void print2DUtil(Node root, int space, int COUNT = 5)
        {

            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.Right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.Value + "\n");

            // Process left child  
            print2DUtil(root.Left, space);
        }



    }
}
