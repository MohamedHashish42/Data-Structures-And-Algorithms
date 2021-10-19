using DataStructure.Trees.BinarySearchTree.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinarySearchTree
{
    class BinarySearchTree<T> where T : BinarySearchTypes
    {
        public BSTNode<T> Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public void insert(T value)
        {

            var newBSTNode = new BSTNode<T>(value);

            if (Root == null)
            {
                Root = newBSTNode;
                return;
            }

            var current = Root;
            while (true)
            {
                if (value.Key < current.Obj.Key)
                {
                    if (current.Left == null)
                    {
                        current.Left = newBSTNode;
                        break;
                    }
                    current = current.Left;

                }
                else if (value.Key > current.Obj.Key)
                {
                    if (current.Right == null)
                    {
                        current.Right = newBSTNode;
                        break;
                    }
                    current = current.Right;
                }
            }


        }


        public BSTNode<T> Search(int key)
        {
            if (Root == null)
            {
                return null;
            }
            BSTNode<T> currentNode = Root;
            while (currentNode != null)
            {
                if (key < currentNode.Obj.Key)
                {
                    currentNode = currentNode.Left;
                }
                else if (key > currentNode.Obj.Key)
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

        #region Remove
        public void Remove(int key)
        {
            if (Root == null)
                return;

            BSTNode<T> currentNode = Root;
            BSTNode<T> parentNode = null;
            while (currentNode != null)
            {
                if (key < currentNode.Obj.Key)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Left;
                }
                else if (key > currentNode.Obj.Key)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Right;
                }


                else if (currentNode.Obj.Key == key)
                {

                    //Option1: Node to be deleted is the leaf
                    if (Isleaf(currentNode) && IsRoot(parentNode)/*Root*/)
                    {
                        Root = null;
                        break;
                    }
                    else if (IsTheRightLeaftToItsParent(currentNode, parentNode))
                    {

                        parentNode.Right = null;
                        break;
                    }
                    else if (IsTheLeftLeaftToItsParent(currentNode, parentNode))
                    {
                        parentNode.Left = null;
                        break;
                    }


                    //Option2: Node to be deleted has only one child
                    if (HasOnlyLeftChild(currentNode))
                    {
                        if (parentNode == null)
                        {
                            Root = currentNode.Left;
                            break;
                        }


                        if (IsTheRightChildToItsParent(currentNode, parentNode))
                        {
                            parentNode.Right = currentNode.Left;
                            break;
                        }
                        else
                        {

                            parentNode.Left = currentNode.Left;
                            break;
                        }

                    }

                    else if (HasOnlyRightChild(currentNode))
                    {
                        if (parentNode == null)
                        {
                            Root = currentNode.Right;
                            break;
                        }


                        if (IsTheRightChildToItsParent(currentNode, parentNode))
                        {
                            parentNode.Right = currentNode.Right;
                            break;
                        }
                        else
                        {

                            parentNode.Left = currentNode.Right;
                            break;
                        }

                    }


                    //Option3: Node to be deleted has two children
                    if (HasTwoChild(currentNode))
                    {

                        var nodeLeft = currentNode.Left;
                        var nodeRigtht = currentNode.Right;

                        var currenLeft = currentNode.Right.Left;
                        var currenLeftParent = currentNode.Right;


                        if (currenLeft == null)
                        {
                            if (IsRoot(parentNode))
                            {
                                Root = nodeRigtht;
                            }

                            else if (IsTheRightChildToItsParent(currentNode, parentNode))
                                parentNode.Right = nodeRigtht;
                            else
                                parentNode.Left = nodeRigtht;


                            nodeRigtht.Left = nodeLeft;
                            break;
                        }


                        while (currenLeft != null)
                        {

                            if (currenLeft.Left == null)
                            {
                                if (IsRoot(parentNode))
                                {
                                    Root = currenLeft;
                                }
                                else
                                if (IsTheRightChildToItsParent(currentNode, parentNode))
                                    parentNode.Right = currenLeft;
                                else
                                    parentNode.Left = currenLeft;


                                currenLeft.Left = nodeLeft;
                                currenLeft.Right = nodeRigtht;
                                currenLeftParent.Left = null;
                                return; //Exit from two whiles;
                            }

                            currenLeftParent = currenLeft;
                            currenLeft = currenLeft.Left;
                        }

                    }
                }
            }
        }

        #region Methods used On Remove Method
        private static bool IsRoot(BSTNode<T> parentNode)
        {
            return parentNode == null;
        }
        private static bool Isleaf(BSTNode<T> currentNode)
        {
            return currentNode.Left == null && currentNode.Right == null;
        }



        private static bool IsTheRightLeaftToItsParent(BSTNode<T> currentNode, BSTNode<T> parentNode)
        {
            return currentNode.Left == null && currentNode.Right == null && currentNode.Obj.Key > parentNode.Obj.Key;
        }
        private static bool IsTheLeftLeaftToItsParent(BSTNode<T> currentNode, BSTNode<T> parentNode)
        {
            return currentNode.Left == null && currentNode.Right == null && currentNode.Obj.Key < parentNode.Obj.Key;
        }


        private static bool HasOnlyRightChild(BSTNode<T> currentNode)
        {
            return currentNode.Right != null && currentNode.Left == null;
        }
        private static bool HasOnlyLeftChild(BSTNode<T> currentNode)
        {
            return currentNode.Left != null && currentNode.Right == null;
        }
        private static bool HasTwoChild(BSTNode<T> currentNode)
        {
            return currentNode.Left != null && currentNode.Right != null;
        }


        private static bool IsTheRightChildToItsParent(BSTNode<T> currentNode, BSTNode<T> parentNode)
        {
            return currentNode.Obj.Key > parentNode.Obj.Key;
        }
        #endregion

        #endregion




        public void printTree()
        {
            print2DUtil(Root, 0);
        }

        private void print2DUtil(BSTNode<T> root, int space, int COUNT = 5)
        {

            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.Right, space);

            // Print current BSTNode after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.Obj.Key + "\n");

            // Process left child  
            print2DUtil(root.Left, space);
        }
    }
}
