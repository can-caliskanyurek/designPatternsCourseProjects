using System;
using DecoratorInDependencyInjection.Interfaces;

namespace DecoratorInDependencyInjection.Classes
{
    public class ReportingService : IReportingService
    {
        public void Report()
        {
            Console.WriteLine("Here is your report");
        }
    }
}