// C# in VS Code
// 1) create new folder
// 2) cmd in file path
// 3) dotnet new console
// 4) code .

// Run C#
// 1) dotnet run 
// 2) run button

// For AutoComplete
// Ctrl Shift P - OmniSharp select project

using System;

namespace c_sharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run Practice Result");

            Console.WriteLine("1 => Practice 1: Basic");
            Console.WriteLine("2 => Practice 2: String");
            Console.WriteLine("3 => Practice 3: Number");
            Console.WriteLine("4 => Application 1: Mad Lib Game");
            Console.WriteLine("5 => Practice 4: Map");
            Console.WriteLine("6 => Practice 5: Function");
            Console.WriteLine("7 => Practice 6: If");
            Console.WriteLine("8 => Practice 7: Static");
            Console.WriteLine("9 => Practice 8: Basic Calculator");
            Console.WriteLine("10 => Practice 9: Loop");


            int runTest = int.Parse(Console.ReadLine());
            PracticeBase practiceClass;
            switch (runTest)
            {
                case 1:
                    practiceClass = new BasicPractice();
                    break;
                case 2:
                    practiceClass = new StringPractice();
                    break;
                case 3:
                    practiceClass = new NumberPractice();
                    break;
                case 4:
                    practiceClass = new MadLibGame();
                    break;
                case 5:
                    practiceClass = new MapPractice();
                    break;
                case 6:
                    practiceClass = new FunctionPractice();
                    break;
                case 7:
                    practiceClass = new IfPractice();
                    break;
                case 8:
                    practiceClass = new StaticPractice();
                    break;
                case 9:
                    practiceClass = new BasicCalculator();
                    break;
                case 10:
                    practiceClass = new LoopPractice();
                    break;

                default:
                    practiceClass = new BasicPractice();
                    break;
            }
            practiceClass.runResult();
        }
    }
}
