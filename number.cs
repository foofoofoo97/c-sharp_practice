using System;

namespace c_sharp_practice
{
    class NumberPractice : PracticeBase
    {
        public override void runResult()
        {
            Console.WriteLine("get integer back " + 1 / 2);
            Console.WriteLine("get decimal back " + 1.0 / 2);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(100));
            Console.WriteLine(Math.Max(100, 1000)); ;
            Console.WriteLine(Math.Round(1.2));
            Console.WriteLine(Math.Round(1.6));

            Console.WriteLine(Convert.ToInt32("1233") + 123);
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);

            Console.WriteLine(Convert.ToInt32("1233") + 123);
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number2);
        }
    }
}

