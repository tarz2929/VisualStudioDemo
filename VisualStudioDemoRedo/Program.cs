using System;
using System.Collections.Generic;

namespace VisualStudioDemoRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 9, 88, 40, 44, 78, 26, 1, 90 };
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            // For each of the numbers in our array of numbers
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                // If the number is even (remainder of division by 2 is 0)
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    // Add it to the even array and increase our count of even numbers
                    evenNumbers.Add(arrayOfNumbers[i]);
                }
                // If it's not even, it's odd
                else
                {
                    // Add it to the odd array and increase our count of odd numbers
                    oddNumbers.Add(arrayOfNumbers[i]);
                }
            }

            Console.WriteLine("Evens:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Odds:");
            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }



    }
}

