using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    class TabulatedSolution
    {
        public static int Fib(int index)
        {

            var fibSeq = new List<int> { 0, 1 };
            for (int i = 2; i <= index; i++)
            {
                fibSeq.Add(fibSeq[i - 1] + fibSeq[i - 2]);
            }

            return fibSeq[index];
        }

    }
}
