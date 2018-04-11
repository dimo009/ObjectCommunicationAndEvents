using _04.Work_force.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Work_force.Models
{
    public class JobEventArgs:EventArgs
    {
        public JobEventArgs(IJob job)
        {
            this.Job = job;
        }

        public IJob Job { get; }
    }
}
