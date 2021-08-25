using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numarray = new int[10];
            numarray[0] = 1;
            numarray[1] = 2;
            numarray[2] = 3;
            numarray[3] = 4;
            numarray[4] = 5;
            numarray[5] = 6;
            numarray[6] = 7;
            numarray[7] = 8;
            numarray[8] = 9;
            numarray[9] = 10;



            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach(var num in numarray)
            {
                if (num%2==0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }



            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("the even numbers");
            foreach(var a in evens)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("the odd numbers");
            foreach (var b in odds)
            {
                Console.WriteLine(b);
            }

        }
    }
}
