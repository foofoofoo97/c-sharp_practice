using System;

namespace c_sharp_practice
{
    class MultiDimensionalArrayPractice : PracticeBase
    {
        public override void runResult()
        {
            /* it is a 3d array */
            int[,,] threedarray = new int[2, 3, 2];

            Console.WriteLine(threedarray);
            // it is a 2d array
            int[,] twodarray = {
                {2,2},
                {3,3}
            };

            Console.WriteLine(twodarray);

        }
    }
}

