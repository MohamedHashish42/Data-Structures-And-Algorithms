using DataStructure.Trees.BinarySearchTree;
using DataStructure.Trees.BinarySearchTree.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Trees.BinaryTree
{
    public class TreesPractices
    {
        public static void CustomBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();


            tree.root = new BTNode<int>(1);

            tree.root.Left = new BTNode<int>(2);
            tree.root.Right = new BTNode<int>(3);

            var rootLeft = tree.root.Left;
            rootLeft.Left = new BTNode<int>(4);


            //                1
            //            /       \
            //           2         3
            //         /    \    /    \
            //        4    null null   null
            //      /    \
            //    null   null


        }

        public static void CustomBinarySearchTree()
        {
            BinarySearchTree<TypeB> BST = new BinarySearchTree<TypeB>();
            BST.insert(new TypeB(8, "Mohamed"));
            BST.insert(new TypeB(5, "Ibrahim"));
            BST.insert(new TypeB(20, "Youssef"));
            BST.insert(new TypeB(3, "Ismail"));
            BST.insert(new TypeB(6, "Mahmoud"));
            BST.insert(new TypeB(15, "Yahya"));
            BST.insert(new TypeB(110, "Khalid"));

            //                8
            //            /       \
            //           5        20
            //         /    \    /    \
            //        3     6   15   110


            BST.printTree();

            var node = BST.Search(20);
            Console.WriteLine(
                "\n Value = " + node.Obj.Value +
                "\n Left Node Value = " + node.Left.Obj.Value +
                "\n Right Node Value = " + node.Right.Obj.Value);


            //BST.insert(new TypeB(150, "Khalid"));
            //BST.insert(new TypeB(100, "Khalid"));
            //BST.insert(new TypeB(200, "Khalid"));

            //BST.insert(new TypeB(120, "Khalid"));

            //BST.insert(new TypeB(2, "Khalid"));
            //BST.insert(new TypeB(4, "Khalid"));

            //BST.Remove(110);


            //                8
            //            /       \
            //           5        20
            //         /    \    /    \
            //        3     6   15   110
            //      /    \          /    \
            //     2      4       100    150   
            //                          /    \
            //                        120    200




        }
    }
}
