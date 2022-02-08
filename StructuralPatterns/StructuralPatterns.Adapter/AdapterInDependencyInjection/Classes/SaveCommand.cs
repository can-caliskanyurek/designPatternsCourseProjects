using AdapterInDependencyInjection.Interfaces;
using System;

namespace AdapterInDependencyInjection.Classes
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving a File");
        }
    }
}
