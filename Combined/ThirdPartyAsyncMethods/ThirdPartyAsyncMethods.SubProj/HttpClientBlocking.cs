namespace ThirdPartyAsyncMethods.SubProj;
public class HttpClientBlocking
{
    public static async Task FooAsync()
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://google.com")
        };

        HttpResponseMessage resp = await httpClient.GetAsync("/");
    }
}
