using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class Example
    {
        public static bool HasPairWithSum(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                        return true;
                }

            }
            return false;

            //Time Complexity  is O(n^2)
            //Space Complexity is O(1)
        }

        public static bool HasPairWithSum2(int[] arr, int sum)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (list.Contains(arr[i]))
                {
                    return true;
                }

                list.Add(sum - arr[i]);
            }
            return false;

            //Time Complexity  is O(n)
            //Space Complexity is O(n)
        }
    }
}
