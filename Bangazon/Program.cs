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
            Operations ops = new Operations("Operations", "Amelia Earhart", "Nashville", 12);
            Sales sales = new Sales("Sales", "Cornelia Fort", "Brentwood", 22);
            HumanResources hr = new HumanResources("Human Resources", "Sally Ride", "Nashville", 5);

            // Add derived departments to the list
            departments.Add(ops);
            departments.Add(sales);
            departments.Add(hr);

            // Iterate over all items in the list and output a string 
            // representation of the class
            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.toString()}");
            }
        }
    }
}

//Create 2 more classes for departments of your choosing.
//Create some instances of each department in the Main method.
//Assign values to the properties of each instance.
//Call come of the methods on the instances to verify their operation.
//Add all derived departments to a List of type Department.