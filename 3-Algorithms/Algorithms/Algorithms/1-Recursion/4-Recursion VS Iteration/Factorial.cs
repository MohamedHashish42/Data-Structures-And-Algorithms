using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    class Factorial
    {
        public static int UsingItteration(int number)
        {
            int factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int UsingRecursion(int number)
        {

            //Base Case
            if (number == 0 || number == 1)
            {
                return 1;
            }
            //Recursive Case
            return number * UsingRecursion(number - 1);
            //5  *  4!
            //      4  *  3!
            //            3  *  2!
            //                  2  * 1!
            //                       1

        }
    }
}
