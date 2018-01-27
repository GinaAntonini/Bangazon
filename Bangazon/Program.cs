using Bangazon.Departments;
using System;
using System.Collections.Generic;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            // Create some instances
            var Operations = new Operations { Name = "Operations", Supervisor = "Amelia Earhart", Location = "Nashville", EmployeeCount = 12 };
            var Sales = new Sales { Name = "Sales", Supervisor = "Cornelia Fort", Location = "Brentwood", EmployeeCount = 22 };
            var Accounting = new Accounting { Name = "Accounting", Supervisor = "Sally Ride", Location = "Nashville", EmployeeCount = 5 };

            // Add derived departments to the list
            departments.Add(Operations);
            departments.Add(Sales);
            departments.Add(Accounting);

            // Iterate over all items in the list and output a string 
            // representation of the class
            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.toString()}");
            }
            Console.ReadLine();
        }
    }
}

//Create 2 more classes for departments of your choosing.
//Create some instances of each department in the Main method.
//Assign values to the properties of each instance.
//Call come of the methods on the instances to verify their operation.
//Add all derived departments to a List of type Department.