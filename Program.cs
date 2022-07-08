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
        public static bool y = false;

        public static void Proceed(string decision)
        {
            if (decision == "y")
            {
                y = true;
            } 
        }
        // static implies that the scope of this method is at the class level, not the object level
        // and can thus be invoked without having to first create a new class instance
        // Hence the Main() method can be run as soon as the program runs
        static void Main(string[] args) //Entry Point
        {
            //List<Employee> employees = GetEmployees();
            List<Employee> employees = PeopleFetcher.GetEmployees();
            if (y)
            {
                List<Employee> employeesAPI = PeopleFetcher.GetFromAPI();
                Util.PrintEmployees(employeesAPI);
                Util.MakeCSV(employeesAPI);
                Util.MakeBadges(employeesAPI);
            }
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
    }
}
