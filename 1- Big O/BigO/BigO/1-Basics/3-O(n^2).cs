using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class Quadratic
    {
        public static void MultiplicationTable(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.WriteLine(i +" * "+j+" =" +i*j);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
