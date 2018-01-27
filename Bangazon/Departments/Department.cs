using System;


namespace Bangazon.Departments
{
    class Department
    {
        private string _name;
        private string _supervisor;
        private string _location;
        private int _employeeCount;

        public string Name;
        public string Supervisor;
        public string Location;
        public int EmployeeCount;

        public Department(string Name, string Supervisor, string Location, int EmployeeCount)
        {
            _name = Name;
            _supervisor = Supervisor;
            _location = Location;
            _employeeCount = EmployeeCount;
        }

        public string toString()
        {
            return $"The department name is {Name} and overseen by {Supervisor}. This department has {EmployeeCount} employees and is housed in our {Location} location.";
        }
    }
}
