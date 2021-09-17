using System;

namespace c_sharp_practice
{
    class MapPractice : PracticeBase
    {

        public override void runResult()
        {
            int[] map = { 1, 2, 3, 4, 5 };
            string[] strings = new string[2];
            strings[0] = "a";
            strings[1] = "1";

            Console.WriteLine(map[1]);
            Console.WriteLine(map.IsFixedSize);

            int[] newClone = (int[])map.Clone();

            int[] newCopy = new int[5];
            map.CopyTo(newCopy, 0);
        }
    }
}

