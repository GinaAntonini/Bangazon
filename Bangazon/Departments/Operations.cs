using System;
using System.Collections.Generic;


namespace Bangazon.Departments
{
    class Operations : Department
    {
        public string HoursOfOperation { get; set; }
        public string Budget { get; set; }

        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public Operations(string name, string supervisor, string location, int employeeCount, Dictionary<string, string> policies) : base(name, supervisor, location, employeeCount)
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




    
