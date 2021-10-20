using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    class DirectAndIndirectRecursion
    {
        #region Direct recursion


        void Fun()
        {
            // Some code....
            Fun();
            // Some code...
        }

        #endregion




        #region Indirect recursion

        void Fun1()
        {
            // Some code...
            Fun2();
            // Some code...
        }
        void Fun2()
        {
            // Some code...
            Fun1();
            // Some code...
        }


        #endregion
    }
}
