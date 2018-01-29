using System;


namespace Bangazon.Departments
{
    abstract partial class Department
    {

        public string Name { get; set; }
        public string Supervisor { get; set; }
        public string Location { get; set; }
        public string MeetingDay { get; set; }
        public int EmployeeCount { get; set; }
        public string Budget { get; set; }

        public string toString()
        {
            return $"The department name is {Name} and overseen by {Supervisor}. This department has {EmployeeCount} employees and is housed in our {Location} location. The set budget for this department is {Budget}";
        }

        public virtual void Meet(string MeetingDay)
        {
            Console.WriteLine($"The {Location} offices will be meeting on {MeetingDay}. ");
        }

        public virtual void SetBudget(double budget)
        {
            this.Budget += 75000;
        }
   }
}

