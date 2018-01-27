using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon.Departments
{
    class Sales : Department
    {
        public string SalesInPipleine { get; set; }
        public string Budget { get; set; }

        private Dictionary<string, string> _policies = new Dictionary<string, string>();


        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }

        }

        // Overriding the default toString() method for each object instance
        public string ToString()
        {
            return $"{SalesInPipeline} {Budget}";
        }
    }
}
