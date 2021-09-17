using System;

namespace c_sharp_practice
{
    class StaticPractice : PracticeBase
    {
        public override void runResult()
        {
            StaticClass.printWhatever();
        }
    }

    class StaticClass
    {
        static string lang1 = "Solidity";
        static string lang2 = "C#";
        static public void printWhatever()
        {
            Console.WriteLine("I hope I can get this job");
            Console.WriteLine("I promise will learn all the required programming languages");
            Console.WriteLine("#1 " + StaticClass.lang1);
            Console.WriteLine("#2 " + StaticClass.lang2);
        }
    }
}

