using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class InsertionSort
    {


        public static int[] Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j;

                // when Key 30
                // 40, 50, 30, 70

                for (j = i - 1; j >= 0 && key < arr[j]; j--)
                {
             
                    //  1th  40, 50, 50, 70
                    //  2th  40, 40, 50, 70

                    arr[j + 1] = arr[j];
            
                   
                }
                
                arr[j + 1] = key; // 30, 40, 50, 70
            }
            return arr;
        }
    


  

    }
}
