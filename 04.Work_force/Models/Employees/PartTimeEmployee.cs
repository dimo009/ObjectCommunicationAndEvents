using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Work_force.Models.Employees
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name) : base(name, workingHoursPerWeek:20)
        {
        }
    }
}
