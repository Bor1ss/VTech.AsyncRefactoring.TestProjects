using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations;
public class FooChild : FooBase
{
    public override string Foo()
    {
        return Guid.NewGuid().ToString();
    }

}
