using _02.KingsGambit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.KingsGambit.Models
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
