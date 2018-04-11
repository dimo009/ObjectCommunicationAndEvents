using _04.Work_force.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Work_force.Models
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
