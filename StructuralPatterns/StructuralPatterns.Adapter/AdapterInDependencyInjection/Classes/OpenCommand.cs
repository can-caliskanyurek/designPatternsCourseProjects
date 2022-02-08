using AdapterInDependencyInjection.Interfaces;
using System;

namespace AdapterInDependencyInjection.Classes
{
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opening a File");
        }
    }
}
