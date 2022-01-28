using System.Threading.Tasks;

namespace AsynchronousFactoryMethod
{
    public class AsynchronousFactoryMethod
    {
        public static async Task Main(string[] args)
        {
            Foo foo = await Foo.CreateAsync();
        }
    }
}
