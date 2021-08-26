using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            var employeeList = new List<Employee>();
            // Create three employees
            var employee1 = new Employee("Dwight", "Schrute", "Salesperson", new DateTime(2021, 08, 22));
            var employee2 = new Employee("Pam", "Beasly", "Secretary", new DateTime(2021, 08, 23));
            var employee3 = new Employee("Michael", "Scott", "Manager", new DateTime(2021, 08, 24));

            // Assign the employees to the company
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            // Create an instance of a company. Name it whatever you like.
            var theOffice = new Company("Dunder Mifflin", new DateTime(2021, 08, 21), employeeList);
            theOffice.ListEmployees();
        }

    }
}