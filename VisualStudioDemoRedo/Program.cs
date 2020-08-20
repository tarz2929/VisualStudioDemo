using System;
using System.Collections.Generic;

namespace VisualStudioDemoRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Practice Spec:
             * Create a program that will generate a 2x2 2 dimmensional array, and will repeatedly display the current layout
             * then prompt the user for a row number, column number, and value until the user enters "exit". 
             * When the user enters the info, overwrite that position with the value the user provided.
             */

            int[,] theArray = new int[2, 2];

            string userInput = "";

            do
            {
                DisplayArray(theArray);

                Console.Write("Please enter \"Exit\" to quit, or anything else to continue: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "exit")
                {
                    int row, column, value;

                    row = GetValidInt("Please enter a row number: ", 0, 2);

                    column = GetValidInt("Please enter a column number: ", 0, 2);

                    value = GetValidInt("Please enter a value: ", int.MinValue, int.MaxValue);

                    theArray[column, row] = value;
                }
            } while (userInput.ToLower() != "exit");
        }

        static void DisplayArray(int[,] arrayToDisplay)
        {
            Console.WriteLine("-----");
            for (int r = 0; r < 2; r++)
            {
                Console.Write("|");
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(arrayToDisplay[c, r] + "|");
                }
                Console.WriteLine("\n-----");
            }
        }

        static int GetValidInt(string prompt, int min, int max)
        {
            bool valid = false;
            int userInput = -1;
            do
            {
                Console.Write(prompt);
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput < min || userInput > max)
                    {
                        throw new Exception("Input was outside of the bounds of the array");
                    }
                    valid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    Console.WriteLine("Please try again.");
                }
            } while (!valid);
            return userInput;
        }
    }
}

