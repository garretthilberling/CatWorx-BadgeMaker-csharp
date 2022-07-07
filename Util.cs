using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                // We want the first argument (argument {0}), the id, to be left-aligned and padded to at least 10 characters, so we enter {0,-10}. 
                // Then we want to print a tab character (\t). 
                // We want the next argument ({1}), the name, to be left-aligned and padded to 20 characters—hence {1,-20}.
                // Next, we want to print another tab character (\t). And finally, we want to print the last argument ({2}), no formatting
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }

        public static void MakeCSV(List<Employee> employees)
        {
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
            // with 'using' .NET will drop SteamWriter when it is done using it. Best practice as it is a heavy resource
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                file.WriteLine("ID,Name,PhotoURL");
                for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0},{1},{2}";
                file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
            }
        }
    }
}