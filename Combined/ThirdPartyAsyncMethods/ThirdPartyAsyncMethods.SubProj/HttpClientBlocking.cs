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
