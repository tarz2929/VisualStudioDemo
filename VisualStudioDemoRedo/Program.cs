using System;

namespace VisualStudioDemoRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArrayOne = { 42, 12, 7, 33, 5, 3 };
            // Clone() will create a copy of the array, as opposed to returning the memory address of the original.
            int[] myArrayTwo = (int[])myArrayOne.Clone();
            //int[] myArrayTwo = myArrayOne;

            myArrayTwo[3] = 100;


        }


    }
}

