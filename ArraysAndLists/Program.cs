using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numPopArray = new int[10] {1,2,3,4,5,6,7,8,9,10};

            /* Create a list of type int
             * Name the list "evens"
             */
            List <int> listEvens = new List<int>(); 
            
            /* Create another list of type int
             * Name the list "odds"
             */
            List <int> listOdds = new List<int>();

             /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */
            foreach(int i in numPopArray)
            {
                if(i % 2 == 0)
                {
                    listEvens.Add(i);
                }
                else
                {
                    listOdds.Add(i);
                }
            }

            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
             foreach(int i in listEvens)
             {
                Console.WriteLine($"The number {i} is even but you should know this from 2nd grade");
             }

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            foreach(int i in listOdds)
             {
                Console.WriteLine($"The number {i} is odd but you should know this from 1st grade");
             }
        }
    }
}
