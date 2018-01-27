using System;
using System.Collections.Generic;


namespace Bangazon.Departments
{
    class Operations : Department
    {
        public string HoursOfOperation { get; set; }
        public string HolidaysToWork { get; set; }

        private Dictionary<string, string> LateDays = new Dictionary<string, string>();

        public void WorkLate(string Holiday, string Time)
        {
            LateDays.Add(Holiday, Time);

            foreach (KeyValuePair<string, string> Day in LateDays)
            {
                Console.WriteLine($"{Name} works late on {Day.Value} because sales increase around this time.");
            }

        }

        // Overriding the default toString() method for each object instance
        public string ToString()
        {
            return $"{HoursOfOperation} {HolidaysToWork}";
        }
    }
}




    
