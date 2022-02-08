using AdapterInDependencyInjection.Classes;
using AdapterInDependencyInjection.Interfaces;
using Autofac;
using Autofac.Features.Metadata;
using System;

namespace AdapterInDependencyInjection
{
    public class AdapterInDependencyInjection
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<SaveCommand>().As<ICommand>().WithMetadata("Name", "Save");
            builder.RegisterType<OpenCommand>().As<ICommand>().WithMetadata("Name", "Open");
            builder.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
                new Button(cmd.Value, (string) cmd.Metadata["Name"])
            );
            builder.RegisterType<Editor>();

            using IContainer container = builder.Build();
            Editor editor = container.Resolve<Editor>();
            editor.ClickAll();
            Console.WriteLine();

            foreach (Button button in editor.Buttons)
            {
                button.PrintMe();
            }
        }
    }
}
