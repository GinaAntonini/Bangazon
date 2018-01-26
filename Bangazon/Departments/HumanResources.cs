using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon.Departments
{
    class HumanResources : Department
    {
        public string HoursOfOperation { get; set; }
        public string Budget { get; set; }

        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public HumanResources(string name, string supervisor, string location, int employeeCount) : base(name, supervisor, location, employeeCount)
        {
        }

        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }

        }

    }
}

