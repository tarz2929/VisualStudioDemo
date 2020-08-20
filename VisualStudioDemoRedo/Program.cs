using System;

namespace VisualStudioDemoRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArrayOne = { 42, 12, 7, 33, 5, 3 };

            // As memory address references, the original array is passed into the method and can be modified therein.
            ModifyArray(myArrayOne);

        }
        static void ModifyArray(int[] theArray)
        {
            theArray[2] = 5;
        }


    }
}

