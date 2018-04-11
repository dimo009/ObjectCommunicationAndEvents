using System;
using System.Collections.Generic;
using System.Text;
using _04.Work_force.Models;

namespace _04.Work_force.Contracts
{
    public interface IJob
    {
        event JobDoneEventHandler JobDone;

        string Name { get; }

        int RequiredHoursOfWork { get; }

        void Update();
    }
}
