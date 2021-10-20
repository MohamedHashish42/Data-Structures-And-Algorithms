using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    class Fibonacci
    {
        // Fibonacci Sequence = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 ......
        public static int UsingItteration(int index)
        {

            var fibSeq = new List<int> { 0, 1 };
            for (int i = 2; i <= index; i++)
            {
                fibSeq.Add(fibSeq[i - 1] + fibSeq[i - 2]);
            }

            return fibSeq[index];
        }



        public static int UsingRecursion(int index)
        {
            if (index < 2)
            {
                return index;
            }
            return UsingRecursion(index - 1) + UsingRecursion(index - 2);

            //Fib(5) =                     Fib(4)                     +                    Fib(3)

            //                   Fib(3)        +       Fib(2)                    Fib(2)      +       Fib(1)

            //         Fib(2)      +     Fib(1)     Fib(1) + Fib(0)         Fib(1) + Fib(0)             1     

            //    Fib(1) + Fib(0)          1          1    +     0            1    +    0

            //      1    +   0
        }
    }
}
