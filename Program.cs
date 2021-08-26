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
            var employee1 = new Employee("Luke", "Madrazo", "Cashier", new DateTime(2021, 08, 21));
            var employee2 = new Employee("Luz", "Madrazo", "Cashier", new DateTime(2021, 04, 18));
            var employee3 = new Employee("Christina", "Ashworth", new DateTime(2021, 09, 14));


            // Assign the employees to the company
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            // Iterate the company's employee list and generate the simple report shown above

            // Create an instance of a comapany. Name it whatever you like.
            var fitFactory = new Company("Dunder Miffin", new DateTime(2021, 10, 14), employeeList);
            fitFactory.ListEmployees();
        }
    }
}