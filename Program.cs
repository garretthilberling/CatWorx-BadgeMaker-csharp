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
        static List<Employee> GetEmployees()
        {
            // will return a list of strings
            List<Employee> employees = new List<Employee>();
            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter first name (leave empty to exit):");
                // Get a name from the console and assign it to a variable
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Photo URL:");
                string photoUrl = Console.ReadLine();
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        // static implies that the scope of this method is at the class level, not the object level
        // and can thus be invoked without having to first create a new class instance
        // Hence the Main() method can be run as soon as the program runs
        static void Main(string[] args) //Entry Point
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
    }
}
