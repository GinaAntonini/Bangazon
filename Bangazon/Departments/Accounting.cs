using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon.Departments
{
    class Accounting : Department, IAccounting
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
        public string ToString()
        {
            return $"{OpenPosition} {BusySeason}";
        }


    }
}

