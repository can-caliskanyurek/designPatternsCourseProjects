using System.Threading.Tasks;

namespace AsynchronousFactoryMethod
{
    public class AsynchronousFactoryMethod
    {
        static async Task Main(string[] args)
        {
            Foo foo = await Foo.CreateAsync();
        }
    }
}
