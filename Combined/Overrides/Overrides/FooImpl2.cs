using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overrides;
public class FooImpl2 : IFoo
{
    public void Foo()
    {
        FooJob();
    }

    public void FooJob()
    {
        Console.WriteLine("FooJob");
    }
}
