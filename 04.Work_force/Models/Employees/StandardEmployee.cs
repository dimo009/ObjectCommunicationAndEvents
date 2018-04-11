using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Work_force.Models.Employees
{
    public class StandardEmployee : Employee
    {
        public StandardEmployee(string name) : base(name, workingHoursPerWeek:40)
        {
        }
    }
}
