using AdapterInDependencyInjection.Interfaces;
using System;

namespace AdapterInDependencyInjection.Classes
{
    public class Button
    {
        private readonly ICommand _command;
        private string name;

        public Button(ICommand command, string name)
        {
            _command = command;
            this.name = name;
        }

        public void Click()
        {
            _command.Execute();
        }

        public void PrintMe()
        {
            Console.WriteLine($"I am a button called {name}");
        }
    }
}
