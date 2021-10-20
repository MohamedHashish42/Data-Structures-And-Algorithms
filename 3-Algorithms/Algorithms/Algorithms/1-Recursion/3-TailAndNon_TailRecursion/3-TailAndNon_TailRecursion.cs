using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    class TailAndNon_TailRecursion
    {
        #region Non Tail Recursion
        public static int NonTRFact(int number)
        {

            //Base Case
            if (number == 0 || number == 1)
            {
                return 1;
            }
            //Recursive Case
            return number * NonTRFact(number - 1);
            //5  *  4!
            //      4  *  3!
            //            3  *  2!
            //                  2  * 1!
            //                       1

        }
        #endregion

        #region  Tail Recursion
        public static int TRFact(int n, int a = 1)
        {
            if (n == 0)
                return a;

            return TRFact(n - 1, n * a);

            // TRFact(5 , 1) = TRFact(5-1 , 5*1) 

            //                 TRFact(4-1 , 4*5) 

            //                 TRFact(3-1 , 3*20)  

            //                 TRFact(2-1 , 2*60) 

            //                 TRFact(1-1 , 1*120)

        }
        #endregion
    }
}
