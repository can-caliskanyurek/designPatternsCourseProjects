using Autofac;
using Bridge.Classes;
using Bridge.Interfaces;

namespace Bridge
{
    public class Bridge
    {
        static void Main(string[] args)
        {
            //IRenderer renderer = new RasterRenderer();
            //IRenderer renderer = new VectorRenderer();

            //Circle circle = new Circle(renderer, 5);

            //circle.Draw();
            //circle.Resize(2);
            //circle.Draw();

            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<RasterRenderer>().As<IRenderer>().SingleInstance();

            containerBuilder.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

            using IContainer container = containerBuilder.Build();
            Circle circle = container.Resolve<Circle>(new PositionalParameter(0, 5.0f));

            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }
    }
}
