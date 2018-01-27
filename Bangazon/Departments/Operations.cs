using System;
using System.Collections.Generic;


namespace Bangazon.Departments
{
    class Operations : Department
    {
        public string HoursOfOperation { get; set; }
        public string HolidaysToWork { get; set; }

        private Dictionary<string, string> LateDays = new Dictionary<string, string>();

        public void WorkLate(string Day, string Time)
        {
            LateDays.Add(Day, Time);

            foreach (KeyValuePair<string, string> LateDay in LateDays)
            {
                Console.WriteLine($"{Name} works late on {LateDay.Key} because sales increase around this time. It sounds like {LateDay.Value} extra hours of work will get the job done.");
            }

        }

        // Overriding the default toString() method for each object instance
        public override string ToString()
        {
            return $"{HoursOfOperation} {HolidaysToWork}";
        }

        public override void SetBudget(double budget)
        {
            this.Budget += budget + 200000.00;
        }
    }
}




    
