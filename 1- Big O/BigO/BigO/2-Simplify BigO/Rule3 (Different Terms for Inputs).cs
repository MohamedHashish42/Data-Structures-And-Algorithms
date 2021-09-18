using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class DifferentTermsForInputs
    {
        public static void PrintNumberInTwoArrays(int [] arr1,int [] arr2)
        {
            var n = arr1.Length;
            var a = arr2.Length;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            //Time complixity for this function = O( n + a)
        }
    }
}
