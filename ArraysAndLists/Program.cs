using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done:
            
            // Create an int Array and populate numbers 1-10
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
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
            foreach (var num in myArray)
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





            //for (int i = 2; i <= 10; i += 2)
            //{
            //    evens.Add(i);
            //}




            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Evens Only!!");
            foreach (var num in evens)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(num);
            }
            
            Console.WriteLine("------------------");
            Console.WriteLine("Odds Only!!");
            foreach (var num in odds)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(num);
            }
        }
    }
}
