using _02.KingsGambit.Core;
using _02.KingsGambit.Models;
using System;

namespace _02.KingsGambit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            new Engine(new ConsoleReader(), new ConsoleWriter()).Run();
        }
    }
}
