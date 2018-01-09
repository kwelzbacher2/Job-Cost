
/* DemoJobs
 * Programmer: K Welzbacher
 * Date: 3/22/17
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new Job objects
            Job floor = new Job("wipe floor", 4.8, 8.75);
            Job paint = new Job("paint trimming", 36.8, 30.75);
            Job both = floor + paint;
            //print out each job
            WriteLine("Information about the first job.");
            PrintOut(floor);
            WriteLine("Information about the second job.");
            PrintOut(paint);
            WriteLine("Information about the combined jobs.");
            PrintOut(both);
            WriteLine("Press the <Enter> key to end this program.");
            Console.Read();

        }
        //method to print out job information
        public static void PrintOut(Job job)
        {
            WriteLine();
            WriteLine("Job Description: " + job.Description);
            WriteLine("Job Completion Time: " + job.Time + " hours. Job Rate Per Hour: " + job.Rate.ToString("C") + ".");
            WriteLine("Job Total Cost: " + job.Total.ToString("c") + ".");
            WriteLine();
        }
    }
}
