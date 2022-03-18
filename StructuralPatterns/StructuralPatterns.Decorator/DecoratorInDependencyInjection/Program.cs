using System;
using Autofac;
using DecoratorInDependencyInjection.Classes;
using DecoratorInDependencyInjection.Interfaces;

namespace DecoratorInDependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<IReportingService>().Named<IReportingService>("reporting");
            builder.RegisterDecorator<IReportingService>(
                (context, service) => new ReportingServiceWithLogging(service), "reporting"
            );

            IContainer container = builder.Build();
            var res = container.Resolve<IReportingService>();
            res.Report();
        }
    }
}
