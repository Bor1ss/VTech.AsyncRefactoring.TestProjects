using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overrides;
public class FooImpl1 : IFoo
{
    public void Foo()
    {
        FooJobAsync().Wait();
    }

    public async Task FooJobAsync()
    {
        await Task.Yield();

        Console.WriteLine("Foo1");
    }
}
