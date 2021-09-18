using System;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basics

            #region Linear
            //Linear.PrinFromOneToNumber(5);
            #endregion

            #region Constant
            //Constant.PrintNumber(5);
            #endregion

            #region Quadratic
            //Square.MultiplicationTable(12);
            #endregion

            #region Factorial
            //Factorial.PrintUntilFactorial(6);
            #endregion

            #region Exponential
            //Exponential.PowerSet("ABC");
            #endregion

            #region Logarithmic
            //BinarySearchTree BST = new BinarySearchTree();
            //BST.Insert(8);
            //BST.Insert(5);
            //BST.Insert(20);
            //BST.Insert(1);
            //BST.Insert(6);
            //BST.Insert(15);
            //BST.Insert(110);
            //BST.printTree();

            ////                8
            ////            /       \
            ////           5        20
            ////         /    \    /    \
            ////        1     6    15   110

            //var node = BST.Search(20);
            //Console.WriteLine(
            //    "\n Value = " + node.Value +
            //    "\n Left Node Value = " + node.Left.Value +
            //    "\n Right Node Value = " + node.Right.Value);
            #endregion

            #region Linearithmic
            //var arr4 = new int[] { 50, 40, 30, 70, 60, 90, 80 };
            //var arrAfterMS = MergeSort.Sort(arr4);
            //Console.WriteLine(string.Join(", ", arrAfterMS));
            #endregion


            #endregion

            #region 2-Simplify BigO

            #region Rule1 (Worst Case)
            //var Names = new string[]
            //{"Ahmed","Fatima" ,"Ali", "khadija", "Mahmoud",
            // "Aisha", "Khalid", "Ibrahim", "Mohamed"  };
            //WorstCase.FindNameInArray(Names, "Mohamed");
            #endregion

            #region Rule2 (Remove Constants)
            //RemoveConstants.PrintFromOneToNumberTwiceAndFromOneToTen(20);
            #endregion

            #region Rule3 (Different Terms For Inputs)
            //var arr1 = new int[] {1,2,3,4,5,6 };
            //var arr2 = new int[] {1,2,3};
            //DifferentTermsForInputs.PrintNumberInTwoArrays(arr1,arr2);
            #endregion

            #region Rule4 (Drop Non Dominants)
            //DropNonDominants.PrintDone(3);
            #endregion

            #endregion

            #region  3-Example
            //var result1 = Example.HasPairWithSum(new int[] { 1, 2, 9, 4 }, 5);
            //var result2 = Example.HasPairWithSum2(new int[] { 1, 2, 9, 4 }, 5);
            //Console.WriteLine("Result 1 : " + result1 + " Result2 : " + result2);
            #endregion

        }

    }
}

