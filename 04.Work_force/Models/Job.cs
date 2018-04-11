using _04.Work_force.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Work_force.Models
{
    public delegate void JobDoneEventHandler(object sender, JobEventArgs args);

    public class Job : IJob
    {
        private IEmployee employee;
        private int requiredHoursOfWork;


        public Job(string name,int requiredHoursOfWeek, IEmployee employee)
        {
            this.Name = name;
            this.RequiredHoursOfWork = requiredHoursOfWeek;
            this.employee = employee;

            
        }
        public string Name { get; private set; }

        public int RequiredHoursOfWork
        {
            get
            {
                return this.requiredHoursOfWork;
            }

            set
            {
                this.requiredHoursOfWork = value;
                if (this.requiredHoursOfWork <= 0)
                {
                    this.requiredHoursOfWork = 0;
                    Console.WriteLine($"Job {this.Name} done!");
                    this.JobDone?.Invoke(this, new JobEventArgs(this));
                }
            }
        }

        public event JobDoneEventHandler JobDone;

        public void Update()
        {
            this.RequiredHoursOfWork -= this.employee.WorkHoursPerWeek;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.RequiredHoursOfWork}";
        }
    }
}
