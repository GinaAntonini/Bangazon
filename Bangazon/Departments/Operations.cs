using System;
using System.Collections.Generic;


namespace Bangazon.Departments
{
    public class Operations
    {
        public string HoursOfOperation { get; set; }
        public string Budget { get; set; }

        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public Operations(string hoursOfOperation, string budget, Dictionary<string, string> policies)
        {
            HoursOfOperation = hoursOfOperation;
            Budget = budget;
            _policies = policies;
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




    
