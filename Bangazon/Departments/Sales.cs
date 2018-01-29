using System;
using System.Collections.Generic;


namespace Bangazon.Departments
{
    class Sales : Department
    {
        public int SalesInPipleine { get; set; }
        public bool UpTheSalesGame { get; set; }

        private Dictionary<string, string> _sales = new Dictionary<string, string>();


        public void CheckThePipeline(int SalesInPipeline)
        {
            if (UpTheSalesGame)
            {
                Console.WriteLine($"There are {SalesInPipeline} sales in the pipeline. That's not enough! Time to up the sales game.");
            }
            else
            {
                Console.WriteLine($"There are {SalesInPipeline} sales in the pipeline. We have plenty of calling to do.");
            }
        }

        public override void SetBudget(double budget)
        {
            this.Budget += budget + 300000.00;
        }
    }
}
