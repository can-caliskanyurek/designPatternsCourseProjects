using Autofac;
using NUnit.Framework;
using Singleton.Classes;
using Singleton.Interfaces;

namespace Singleton.Test
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void IsSingletonTest()
        {
            SingletonDatabase db = SingletonDatabase.Instance;
            SingletonDatabase db2 = SingletonDatabase.Instance;

            Assert.That(db, Is.SameAs(db2));
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }

        [Test]
        public void SingletonTotalPopulationTest()
        {
            SingletonRecordFinder recordFinder = new SingletonRecordFinder();
            string[] names = new[] { "Seoul", "Mexico City" };
            int totalPopulation = recordFinder.GetTotalPopulation(names);

            Assert.That(totalPopulation, Is.EqualTo(34900000));
        }

        [Test]
        public void ConfigurablePopulationTest()
        {
            ConfigurableRecordFinder recordFinder = new ConfigurableRecordFinder(new DummyDatabase());
            string[] names = new[] { "alpha", "gamma" };
            int totalPopulation = recordFinder.GetTotalPopulation(names);

            Assert.That(totalPopulation, Is.EqualTo(4));
        }

        [Test]
        public void DependencyInjectionPopulationTest()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder(); // Autofac package

            containerBuilder.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
            containerBuilder.RegisterType<ConfigurableRecordFinder>();

            using var container = containerBuilder.Build();
            ConfigurableRecordFinder recordFinder = container.Resolve<ConfigurableRecordFinder>();
        }
    }
}