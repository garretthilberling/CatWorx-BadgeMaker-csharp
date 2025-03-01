﻿// using is similar to require or import
// without System, every time Console is used, it would need to be preceded by System and a period
using System;
// to use dictionaries:
using System.Collections.Generic;

// namespace is similar to modules in node.js
namespace DogWorx.BadgeMaker
// everything inside the curly braces can be interpreted as members of this namespace
{
    class Program
    {
        // static implies that the scope of this method is at the class level, not the object level
        // and can thus be invoked without having to first create a new class instance
        // Hence the Main() method can be run as soon as the program runs
        static void Main(string[] args) //Entry Point
        {
            List<Employee> employees = PeopleFetcher.GetEmployees();
            List<Employee> employeesAPI = null;
            
            if (Util.y)
            {
                employeesAPI = PeopleFetcher.GetFromAPI();
            }

            Util.PrintEmployees(employees, employeesAPI);
            Util.MakeCSV(employees, employeesAPI);
            Util.MakeBadges(employees, employeesAPI);
        }
    }
}
