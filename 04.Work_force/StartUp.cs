using _04.Work_force.Core;
using _04.Work_force.Models;
using System;

namespace _04.Work_force
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            new Engine(reader, writer).Run();
        }
    }
}
