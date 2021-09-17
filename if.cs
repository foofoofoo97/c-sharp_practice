using System;

namespace c_sharp_practice
{
    class IfPractice : PracticeBase
    {
        public override void runResult()
        {
            bool isStudent = true;
            bool isMale = false;
            string name = "foofoofoo";
            if (isStudent)
            {
                if (isMale && name.Equals("foofoofoo"))
                {
                    Console.WriteLine("I am foofoofoo, a male and a student");
                }
                else if (!isMale && name.Equals("foofoofoo"))
                {
                    Console.WriteLine("I am foofoofoo, a female and a student");
                }
                else
                {
                    Console.WriteLine("I donno who you are");
                }
            }
        }
    }
}

