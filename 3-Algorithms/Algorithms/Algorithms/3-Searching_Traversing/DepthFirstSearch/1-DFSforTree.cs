using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching_Traversing
{

    class DFSforTree
    {

        public static List<int> TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.Value);

            if (node.Left != null)
            {
                TraversePreOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                TraversePreOrder(node.Right, list);
            }

            return list;

            /*
              9
              TraversePreOrder(node 9)
              4
              TraversePreOrder(node 4)
              1
              TraversePreOrder(node 1)
              6
              TraversePreOrder(node 6)
              20
              TraversePreOrder(node 20)
              15
              TraversePreOrder(node 15)
              170
              TraversePreOrder(node 170)
             */

            // 9, 4, 1, 6, 20, 15, 170
        }

        public static List<int> TraverseInOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraverseInOrder(node.Left, list);
            }

            list.Add(node.Value);

            if (node.Right != null)
            {
                TraverseInOrder(node.Right, list);
            }

            return list;

            /*
              TraversePreOrder(node 9)
              TraversePreOrder(node 4)
              TraversePreOrder(node 1)
              1
              4
              TraversePreOrder(node 6)
              6
              9
              TraversePreOrder(node 20)
              TraversePreOrder(node 15)
              15
              20
              TraversePreOrder(node 170)
              170
             */
            // 1, 4, 6, 9, 15, 20, 170

        }


        public static List<int> TraversePostOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraversePostOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                TraversePostOrder(node.Right, list);
            }
            list.Add(node.Value);

            return list;

            /*
              TraversePreOrder(node 4)
              TraversePreOrder(node 1)
              1
              TraversePreOrder(node 6)
              6             
              4
              TraversePreOrder(node 20)
              TraversePreOrder(node 15)
              15
              TraversePreOrder(node 170)
              170
              20
              9            
             */
            // 1, 6, 4, 15, 170, 20, 9
        }



    }
}