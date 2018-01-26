using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon.Departments
{
    class Department
    {
        private string _name;
        private string _supervisor;
        private string _location;
        private int _employee_count;

        public Department(string name, string supervisor, string location, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _location = location;
            _employee_count = employees;
        }
    }
}
