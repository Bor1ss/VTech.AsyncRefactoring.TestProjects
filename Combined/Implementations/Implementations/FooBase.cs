using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations;
public class FooBase : IFoo
{
    public virtual string Foo()
    {
        return GetFooAsync().GetAwaiter().GetResult();
    }

    public async Task<string> GetFooAsync()
    {
        await Task.Yield();

        return Guid.NewGuid().ToString();
    }
}
