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
    class BasicPractice : PracticeBase
    {
        public override void runResult()
        {
            Console.Write("Your First Name: ");
            String firstname = Console.ReadLine();

            Console.Write("Your Last Name: ");
            String lastname = Console.ReadLine();

            Console.WriteLine("Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is " + firstname + " " + lastname);
            Console.WriteLine("At age of " + age);

            //other data types
            string name = "foofoofoo";
            char gender = 'f';
            int myAge = 24;
            double cgpa = 3.85;
            bool isAlive = true;

            Console.WriteLine(name + '\n' + gender + '\n' + myAge + '\n' + cgpa + '\n' + isAlive);


        }
    }
}
