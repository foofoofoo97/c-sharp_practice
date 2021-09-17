using System;

namespace c_sharp_practice
{
    class StringPractice : PracticeBase
    {
        public override void runResult()
        {
            string name = "foofoofoo";
            Console.WriteLine(name.Contains("foo"));
            Console.WriteLine(name.Substring(3, 3));
            Console.WriteLine(name.IndexOf('o'));
            Console.WriteLine(name[2]);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Length);
            Console.WriteLine(name.CompareTo("foo"));
            Console.WriteLine(name.EndsWith("o"));
        }
    }
}

