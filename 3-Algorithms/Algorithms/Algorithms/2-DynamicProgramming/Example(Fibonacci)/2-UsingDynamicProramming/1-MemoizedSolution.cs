using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    class MemoizedSolution
    {

        // Fibonacci Sequence = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 ....


        public Dictionary<int, int> Cache = new Dictionary<int, int>();
        public int Fib1(int index)
        {

            if (index < 2)
            {
                return index;
            }
            if (Cache.ContainsKey(index))
            {
                return Cache[index];
            }
            else
            {
                Cache[index] = Fib1(index - 1) + Fib1(index - 2);
                return Cache[index];
            }
            //                                                        Fib(6) 

            //                               Fib(5)                     +                    Fib(4)

            //                   Fib(4)        +       Fib(3)        

            //         Fib(3)      +     Fib(2)    

            //    Fib(2) + Fib(1)    
        }

        public Func<int, int> Fib2()
        {
            var cache = new Dictionary<int, int>();

            return (index) =>
            {
                if (index < 2)
                {
                    return index;
                }

                if (cache.ContainsKey(index))
                {
                    return cache[index];
                }

                else
                {
                    cache[index] = Fib2()(index - 1) + Fib2()(index - 2);

                    return cache[index];
                }

            };

            //                                                        Fib(6) 

            //                               Fib(5)                     +                    Fib(4)

            //                   Fib(4)        +       Fib(3)        

            //         Fib(3)      +     Fib(2)    

            //    Fib(2) + Fib(1)  
        }
    }
}

