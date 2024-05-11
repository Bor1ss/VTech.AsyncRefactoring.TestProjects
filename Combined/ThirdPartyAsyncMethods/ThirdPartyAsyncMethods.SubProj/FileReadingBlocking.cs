using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyAsyncMethods.SubProj;
public class FileReadingBlocking
{
    public static string Foo()
    {
        return File.ReadAllTextAsync("").GetAwaiter().GetResult();
    }
}
