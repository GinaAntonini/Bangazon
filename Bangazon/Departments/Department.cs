using System;


namespace Bangazon.Departments
{
    class Department
    {
        private string _name;
        private string _supervisor;
        private string _location;
        private int _employeeCount;

        public Department(string name, string supervisor, string location, int employeeCount)
        {
            _name = name;
            _supervisor = supervisor;
            _location = location;
            _employeeCount = employeeCount;
        }

        public string toString()
        {
            return $"Department: {_name}; Supervisor: {_supervisor}; Location: {_location}; Employee count: {_employeeCount}";
        }
    }
}
