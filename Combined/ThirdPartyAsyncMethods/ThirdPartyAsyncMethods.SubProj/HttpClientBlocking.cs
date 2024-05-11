using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyAsyncMethods.SubProj;
public class HttpClientBlocking
{
    public static void Foo()
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://google.com")
        };

        HttpResponseMessage resp = httpClient.GetAsync("/").Result;
    }
}
