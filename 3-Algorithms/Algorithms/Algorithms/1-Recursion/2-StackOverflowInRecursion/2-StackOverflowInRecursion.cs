using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    class StackOverflowInRecursion
    {
        #region Base case is not reached

        int Fact(int n)
        {
            //Here if i called Fact as Fact(10) the
            //base case is never reached
            if (n == 100)
                return 1;

            else
                return n * Fact(n - 1);
        }

        #endregion



        #region Base case is not defined

        int fact(int n)
        {
            return n * fact(n - 1);
        }



        #endregion
    }
}
