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
            
            Operations.WorkLate("Christmas", "5");
            Sales.Meet("Thursday");
            Sales.CheckThePipeline(50);
            Accounting.ExtraWork("CPA");


            double baseBudget = 75000.00;

            foreach (Department d in departments)
            {
                d.SetBudget(baseBudget);
                Console.WriteLine($"{d.toString()}");
            }

            Console.ReadLine();
        
        }
    }
}