using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    class RecursiveSolution
    {

        public static int Fib(int index)
        {
            if (index < 2)
            {
                return index;
            }
            return Fib(index - 1) + Fib(index - 2);

            //                                                      Fib(6) 

            //                              Fib(5)                     +                    Fib(4)

            //                   Fib(4)        +       Fib(3)                    Fib(3)      +       Fib(2)

            //         Fib(3)      +     Fib(2)     Fib(2) + Fib(1)         Fib(2) + Fib(1)              

            //    Fib(2) + Fib(1)    

        }
    }
}
