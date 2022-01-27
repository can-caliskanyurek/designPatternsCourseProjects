using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousFactoryMethod
{
    public class Foo
    {
        private Foo()
        {

        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static Task<Foo> CreateAsync()
        {
            Foo result = new Foo();
            return result.InitAsync();
        }
    }
}
