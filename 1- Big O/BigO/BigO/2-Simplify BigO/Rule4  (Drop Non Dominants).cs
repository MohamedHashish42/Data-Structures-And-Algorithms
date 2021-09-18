using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class DropNonDominants
    {
        public static void PrintDone(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Done"); //O(n^2)
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Done"); //O(n)
            }
            //Time complixity for this function = O(n^2 + n) = O(n^2)
        }
    }
}
