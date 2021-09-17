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

            int runTest = int.Parse(Console.ReadLine());
            switch (runTest)
            {
                case 1:
                    BasicPractice.runResult();
                    break;
                case 2:
                    StringPractice.runResult();
                    break;
                case 3:
                    NumberPractice.runResult();
                    break;
            }
        }
    }
}
