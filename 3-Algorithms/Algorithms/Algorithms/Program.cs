
using Algorithms.DynamicProgramming;
using Algorithms.Recursion;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {



            #region 1-Recursion

            //Console.WriteLine("Factorial(" + 5 + ") Using Non-tail Recursion = "
            //                + TailAndNon_TailRecursion.NonTRFact(5));


            //Console.WriteLine("Factorial(" + 5 + ") Using Tail Recursion = "
            //                   + TailAndNon_TailRecursion.TRFact(5));



            //Console.WriteLine("Factorial(" + 5 + ") Using Itteration : "
            //                   + Factorial.UsingItteration(5));
            //Console.WriteLine("Factorial(" + 5 + ") Using Recursion : "
            //                   + Factorial.UsingRecursion(5));


            //Console.WriteLine("Fibonacci(" + 5 + ") Using Itteration : "
            //                   + Fibonacci.UsingItteration(5));
            //Console.WriteLine("Fibonacci(" + 5 + ") Using Recursion : "
            //                   + Fibonacci.UsingRecursion(5));


            #endregion

            #region 2-Dynamic Programming

            RecursiveSolution.Fib(6);

            MemoizedSolution fm = new MemoizedSolution();
            Console.WriteLine(fm.Fib1(6));
            Console.WriteLine(fm.Fib2()(6));

            TabulatedSolution.Fib(6);

            #endregion



        }
    }
}

