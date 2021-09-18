using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class RemoveConstants
    {
        public static void PrintFromOneToNumberTwiceAndFromOneToTen(int number)
        {
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine(i);  //O(n)
            }

            for (int i = 1; i < number; i++)
            {
                Console.WriteLine(i);  //O(n)
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);  //O(10)
            }


            //Time complixity for this function 
            // = O(2n + 10)
            // = O(2n + 1)
            // = O(n)  
        }
    }
}
