using System;
using System.Collections.Generic;
using System.Text;

namespace BigO
{
    class Constant 
    {
        public static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }

        public static void PrintNumberTwice(int number) 
        {
            //This method gives O(2)

            Console.WriteLine(number); //O(1)
            Console.WriteLine(number); //O(1)
        }


        public static void PrintNumberThrice(int number)
        {
            //This method gives O(3)

            Console.WriteLine(number); //O(1)
            Console.WriteLine(number); //O(1)
            Console.WriteLine(number); //O(1)
        }

        public static void PrintNumberFourTimes(int number)
        {
            //This method gives O(4)

            Console.WriteLine(number); //O(1)
            Console.WriteLine(number); //O(1)
            Console.WriteLine(number); //O(1)
            Console.WriteLine(number); //O(1)
        }

    }
}
