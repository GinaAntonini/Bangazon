using System;

namespace Bangazon.Departments
{
    class Accounting : Department 
    {
        public string OpenPosition { get; set; }
        public bool BusySeason { get; set; }


        public void ExtraWork(string openPosition)
        {
            if (BusySeason)
            {
                Console.WriteLine($"There are {OpenPosition} positions open in the {Name} department.");
            }
            else
            {
                Console.WriteLine($"Since it's not tax season, there are {OpenPosition} positions open.");
            }

        }

        // Overriding the default toString() method for each object instance
        public override string ToString()
        {
            return $"{OpenPosition} {BusySeason}";
        }

        public override void SetBudget(double budget)
        {
            this.Budget += budget + 400000.00;
        }
    }
}

