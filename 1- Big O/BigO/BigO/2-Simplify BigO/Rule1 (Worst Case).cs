using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class WorstCase
    {
        public static void FindNameInArray(string [] arr,string name)
        {
            foreach (var item in arr)
            {
                if (item == name)
                {
                    Console.WriteLine(name);  //O(n)
                    break;
                }
            }
        }
    }
}
