using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class Exponential
    {
        public static List<string> PowerSet(string input)
        {
            int n = input.Length;

            // Power set contains 2^N subsets.
            // . . . 2^5   2^4  2^3  2^2  2^1  2^0 
            // . . . 32     16    8   4    2   1

            int powerSetCount = 1 << n;
            var ans = new List<string>();
            for (int counter = 0; counter < powerSetCount; counter++)
            {
                ans.Add(GetSet(input, n, counter));  //O(2^n)
            }
            ans.ForEach(s => Console.WriteLine(s));
            return ans;
        }

        public static string GetSet(string input, int n, int counter)
        {
            var s = new StringBuilder();
        
            for (int j = 0; j < n; j++)
            {
                //Console.WriteLine((counter ) +" & " +(1 << j)+" = "+(counter & (1 << j)));
                if ((counter & (1 << j)) > 0)
                {
                    s.Append(input[j]);
                }
            }
            // Console.WriteLine("-----------------------------");
            return s.ToString();
        }
    }
}

