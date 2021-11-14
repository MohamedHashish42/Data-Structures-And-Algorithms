using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class SelectionSort
    {

        public static int[] Sort(int[] arr)
        {
            var n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                var min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                // Swap the found minimum element 
                var temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

    }
}
