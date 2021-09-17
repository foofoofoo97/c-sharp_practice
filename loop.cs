using System;

namespace c_sharp_practice
{
    class LoopPractice : PracticeBase
    {
        public override void runResult()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int i = 0;

            Console.WriteLine("While Loop");
            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
            }

            Console.WriteLine("Do While Loop");

            /// will print one time of i even though
            /// i is not greater than its length
            do
            {
                Console.WriteLine(i);
            } while (i > array.Length);

            foreach (int val in array)
            {
                if (val == 3)
                    break;
                Console.WriteLine(val);
            }
        }
    }
}

