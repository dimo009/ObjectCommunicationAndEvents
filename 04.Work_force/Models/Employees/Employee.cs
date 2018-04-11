using _04.Work_force.Contracts;
using System;


namespace _04.Work_force.Models.Employees
{
    public abstract class Employee : IEmployee
    {
        public Employee(string name, int workingHoursPerWeek)
        {
            this.Name = name;
            this.WorkHoursPerWeek = workingHoursPerWeek;
        }
        public string Name { get; private set; }
        public int WorkHoursPerWeek { get; private set; }
    }
}
