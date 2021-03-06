﻿using System;

namespace _01._EventImplementation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler(new ConsoleWriter());

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            var dispatcherName = Console.ReadLine();

            while (dispatcherName != "End")
            {
                dispatcher.Name = dispatcherName;
                dispatcherName = Console.ReadLine();
            }
        }
    }
}
