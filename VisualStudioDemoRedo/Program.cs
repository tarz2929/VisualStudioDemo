using System;

namespace VisualStudioDemoRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 9, 88, 40, 44, 78, 26, 1, 90 };
            int[] oddNumbers = new int[8], evenNumbers = new int[8];
            int oddCount = 0, evenCount = 0;

            // For each of the numbers in our array of numbers
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            { 
                // If the number is even (remainder of division by 2 is 0)
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    // Add it to the even array and increase our count of even numbers
                    evenNumbers[evenCount] = arrayOfNumbers[i];
                    evenCount++;
                }
                // If it's not even, it's odd
                else
                {
                    // Add it to the odd array and increase our count of odd numbers
                    oddNumbers[oddCount] = arrayOfNumbers[i];
                    oddCount++;
                }
            }

            Console.WriteLine("Evens:");
            foreach(int number in evenNumbers)
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

