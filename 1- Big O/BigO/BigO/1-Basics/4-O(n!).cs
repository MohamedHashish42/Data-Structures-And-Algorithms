using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class Factorial
    {
        public static void PrintUntilFactorial(int n)
        {

            for (int i = 1; i <= Fact(n); i++)
            {
                Console.WriteLine(i); //O(n!)
            }
        }

        public static int Fact(int number)
        {
            int factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
