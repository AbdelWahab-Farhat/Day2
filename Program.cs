using System;
using System.Collections.Generic;
using Day2App; // Make sure this matches the namespace of Employee class

namespace Day2App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Day 2 APP!");

            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice Johnson", Designation = "Software Engineer", Salary = 75000, Doj = new DateTime(2020, 5, 15) },
                new Employee { Id = 2, Name = "Bob Smith", Designation = "Project Manager", Salary = 90000, Doj = new DateTime(2018, 3, 10) },
                new Employee { Id = 3, Name = "Charlie Brown", Designation = "QA Engineer", Salary = 65000, Doj = new DateTime(2021, 7, 20) },
                new Employee { Id = 4, Name = "David Wilson", Designation = "HR Specialist", Salary = 55000, Doj = new DateTime(2019, 1, 5) },
                new Employee { Id = 5, Name = "Eve Adams", Designation = "DevOps Engineer", Salary = 80000, Doj = new DateTime(2017, 11, 25) },           
                new Employee { Id = 5, Name = "Eve Adams", Designation = "DevOps Engineer", Salary = 80000, Doj = new DateTime(2017, 11, 25) }
            };

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Designation} - ${emp.Salary}  -  {emp.Doj} ");
            }
        }
    }
}
