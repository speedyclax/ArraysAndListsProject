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
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            //for (int i= 0; i < numbers.Length; i++)
            //{
            //    if ( numbers[i] % 2 == 0)
            //    {
            //        evens.Add(numbers[i]);
            //    }
            //    else
            //    {
            //        odds.Add(numbers[i]);
            //    }
            //}

            foreach (int i in numbers)
            {
                if (i%2==0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }
            //Console.WriteLine(evens.Count);

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (int evenNum in evens)
            {
                Console.WriteLine($"{evenNum} is even");
            }
            foreach (int oddNum in odds)
            {
                Console.WriteLine($"{oddNum} is odd");
            }
        }
    }
}
