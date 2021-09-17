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
    class BasicCalculator : PracticeBase
    {
        public override void runResult()
        {
            Console.Write("Write Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write Operation: ");
            string operation = Console.ReadLine();

            Console.Write("Write Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 + num2);
                    break;
                case "/":
                    Console.WriteLine(num1 - num2);
                    break;
                default:
                    Console.WriteLine("Operation Not Supported");
                    break;
            }

        }
    }
}
