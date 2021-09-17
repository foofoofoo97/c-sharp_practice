using System;

namespace c_sharp_practice
{
    class FunctionPractice : PracticeBase
    {
        public override void runResult()
        {
            runFunction("foo");
            runFunction("fresh graduate");
            runFunction("motivated");

            Console.WriteLine(cube(3));
        }

        protected static void runFunction(String name)
        {
            Console.WriteLine("I am " + name);
        }

        protected static int cube(int num)
        {
            return num * num * num;
        }
    }
}

