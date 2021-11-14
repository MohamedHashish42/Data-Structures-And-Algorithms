
using Algorithms.DynamicProgramming;
using Algorithms.Recursion;
using Algorithms.Searching_Traversing;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 1-Recursion

            //Console.WriteLine("Factorial(" + 5 + ") Using Non-tail Recursion = "
            //                + TailAndNon_TailRecursion.NonTRFact(5));


            //Console.WriteLine("Factorial(" + 5 + ") Using Tail Recursion = "
            //                   + TailAndNon_TailRecursion.TRFact(5));



            //Console.WriteLine("Factorial(" + 5 + ") Using Itteration : "
            //                   + Factorial.UsingItteration(5));
            //Console.WriteLine("Factorial(" + 5 + ") Using Recursion : "
            //                   + Factorial.UsingRecursion(5));


            //Console.WriteLine("Fibonacci(" + 5 + ") Using Itteration : "
            //                   + Fibonacci.UsingItteration(5));
            //Console.WriteLine("Fibonacci(" + 5 + ") Using Recursion : "
            //                   + Fibonacci.UsingRecursion(5));


            #endregion

            #region 2-Dynamic Programming

            //RecursiveSolution.Fib(6);

            //MemoizedSolution fm = new MemoizedSolution();
            //Console.WriteLine(fm.Fib1(6));
            //Console.WriteLine(fm.Fib2()(6));

            //TabulatedSolution.Fib(6);

            #endregion

            #region 3-Searching_Traversing

            #region Breadth First Search For Tree
            //BinarySearchTree tree = new BinarySearchTree();
            //tree.Insert(9);
            //tree.Insert(4);
            //tree.Insert(6);
            //tree.Insert(20);
            //tree.Insert(170);
            //tree.Insert(15);
            //tree.Insert(1);
            ///* 
            //                  9
            //               /     \
            //              4      20
            //            /  \   /   \
            //           1    6 15  170
            //*/

            #region BFS Iterative
            //var BFSIterativeResult = BFSforTree.BFS_Iterative(tree.Root);
            //Console.WriteLine(string.Join(", ", BFSIterativeResult));
            //Console.WriteLine();
            #endregion
            #region  BFS Recurcive
            //List<int> list = new List<int>();
            //Queue<Node> queue = new Queue<Node>();
            //queue.Enqueue(tree.Root);
            //var BFSRecurciveResult = BFSforTree.BFS_Recurcive(queue, list);
            //Console.WriteLine(string.Join(", ", BFSRecurciveResult));
            //Console.WriteLine();
            #endregion
            #endregion

            #region Breadth First Search For graph


            #region Connected Graph


            //Graph<string> myGraph1 = new Graph<string>(true);
            //myGraph1.AddVertex("A");
            //myGraph1.AddVertex("B");
            //myGraph1.AddVertex("C");
            //myGraph1.AddVertex("D");
            //myGraph1.AddEdge("A", "B");
            //myGraph1.AddEdge("A", "C");
            //myGraph1.AddEdge("C", "A");
            //myGraph1.AddEdge("B", "C");
            //myGraph1.AddEdge("C", "D");
            //myGraph1.AddEdge("D", "C");
            //BFSforGraph<string>.BFS(myGraph1, "C");

            #endregion


            #region  Disconnected Graph

            //Graph<string> myGraph2 = new Graph<string>(true);
            //myGraph2.AddVertex("A");
            //myGraph2.AddVertex("B");
            //myGraph2.AddVertex("C");
            //myGraph2.AddVertex("D");
            //myGraph2.AddEdge("A", "B");
            //myGraph2.AddEdge("C", "D");
            //BFSforGraph<string>.BFS(myGraph2);
            #endregion
            #endregion


            #region  Depth First Search For tree
            //BinarySearchTree BTree2 = new BinarySearchTree();
            //BTree2.Insert(9);
            //BTree2.Insert(4);
            //BTree2.Insert(6);
            //BTree2.Insert(20);
            //BTree2.Insert(170);
            //BTree2.Insert(15);
            //BTree2.Insert(1);
            ///* 
            //                  9
            //               /     \
            //              4      20
            //            /  \   /   \
            //           1    6 15  170
            //*/
            //var result1 = DFSforTree.TraversePreOrder(BTree2.Root, new List<int>());
            //Console.WriteLine(string.Join(", ", result1) + "\n");
            //// 9, 4, 1, 6, 20, 15, 170

            //var result2 = DFSforTree.TraverseInOrder(BTree2.Root, new List<int>());
            //Console.WriteLine(string.Join(", ", result2) + "\n");
            //// 1, 4, 6, 9, 15, 20, 170

            //var result3 = DFSforTree.TraversePostOrder(BTree2.Root, new List<int>());
            //Console.WriteLine(string.Join(", ", result3) + "\n");
            //// 1, 6, 4, 15, 170, 20, 9

            #endregion

            #region Depth First Search For Graph
            #region Connected Graph


            //Graph<string> myGraph3 = new Graph<string>(true);
            //myGraph3.AddVertex("A");
            //myGraph3.AddVertex("B");
            //myGraph3.AddVertex("C");
            //myGraph3.AddVertex("D");
            //myGraph3.AddEdge("A", "B");
            //myGraph3.AddEdge("A", "C");
            //myGraph3.AddEdge("C", "A");
            //myGraph3.AddEdge("B", "C");
            //myGraph3.AddEdge("C", "D");
            //myGraph3.AddEdge("D", "C");
            //DFSforGraph<string>.DFS(myGraph3, "C");

            #endregion


            #region  Disconnected Graph
            //Graph<string> myGraph4 = new Graph<string>(true);
            //myGraph4.AddVertex("A");
            //myGraph4.AddVertex("B");
            //myGraph4.AddVertex("C");
            //myGraph4.AddVertex("D");
            //myGraph4.AddEdge("A", "B");
            //myGraph4.AddEdge("C", "D");
            //DFSforGraph<string>.DFS(myGraph4);
            #endregion

            #endregion

            #endregion

            #region 4- Sorting

            #region InsertionSort Sort
            //var arr1 = new int[] { 50, 40, 30, 70 };
            //var arrAfterIS = InsertionSort.Sort(arr1);
            //Console.WriteLine(string.Join(", ", arrAfterIS));
            #endregion

            #region Selection Sort
            //var arr2 = new int[] { 50, 40, 30, 70 };
            //var arrAfterSS = SelectionSort.Sort(arr2);
            //Console.WriteLine(string.Join(", ", arrAfterSS));
            #endregion

            #region Bubble Sort
            //var arr3 = new int[] { 50, 40, 30, 70 };
            //var arrAfterBS = BubbleSort.Sort(arr3);
            //Console.WriteLine(string.Join(", ", arrAfterBS));
            #endregion



            #region Merge Sort
            //var arr4 = new int[] { 50, 40, 30, 70, 60, 90, 80 };
            //var arrAfterMS = MergeSort.Sort(arr4);
            //Console.WriteLine(string.Join(", ", arrAfterMS));
            #endregion

            #region Quick Sort
            //var arr5 = new int[] { 50, 70,80, 90,100,40, 30,7, 60,8, 9 };
            //int n = arr5.Length;
            //var arrAfterQS = QuickSortTT.Sort(arr5, 0, n - 1);
            //Console.WriteLine(string.Join(", ", arrAfterQS));

            #endregion

            #endregion



        }
    }
}

