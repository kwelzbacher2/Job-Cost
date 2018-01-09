using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJobs
{
    class Job
    {
        //declare variables
        private string description;
        private double time;
        private double rate;
        private double total;

        //create constructor
        public Job(string description, double time, double rate)
        {
            Description = description;
            Time = time;
            Rate = rate;
        }

        //create method to overload + operator
        public static Job operator +(Job j1, Job j2)
        {
            return new Job(j1.description + j2.description, j1.time + j2.time, (j1.rate + j2.rate) / 2);
        }

        //make get and set for properties
        public string Description
        {
            get
            {
                return description;
            }
            private set
            {
                description = value;
            }
        }
        public double Time
        {
            get
            {
                return time;
            }
            private set
            {
                time = value;
                total = rate * time;
            }
        }

        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
                total = rate * time;
            }
        }
        public double Total
        {
            get
            {
                return total;
            }
        }
    }
}
