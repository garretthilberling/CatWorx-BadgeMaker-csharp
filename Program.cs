// using is similar to require or import
// without System, every time Console is used, it would need to be preceded by System and a period
using System;
// to use dictionaries:
using System.Collections.Generic;

// namespace is similar to modules in node.js
namespace CatWorx.BadgeMaker
// everything inside the curly braces can be interpreted as members of this namespace
{
    class Program
    {
        static List<string> GetEmployees()
        {
            // will return a list of strings
            List<string> employees = new List<string>();
            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name (leave empty to exit):");
                // Get a name from the console and assign it to a variable
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                employees.Add(input);
            }
            return employees;
        }

        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        // static implies that the scope of this method is at the class level, not the object level
        // and can thus be invoked without having to first create a new class instance
        // Hence the Main() method can be run as soon as the program runs
        static void Main(string[] args) //Entry Point
        {
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}
