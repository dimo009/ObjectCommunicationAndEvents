using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Work_force.Contracts
{
    public interface IEmployee
    {
        string Name { get;  }

        int WorkHoursPerWeek { get; }
    }
}
