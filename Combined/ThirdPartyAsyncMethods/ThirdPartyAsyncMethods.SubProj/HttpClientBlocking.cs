namespace ThirdPartyAsyncMethods.SubProj;
public class HttpClientBlocking
{
    //public static void Foo()
    //{
    //    HttpClient httpClient = new()
    //    {
    //        BaseAddress = new Uri("https://google.com")
    //    };

    //    HttpResponseMessage resp = httpClient.GetAsync("/").Result;
    //}
   
    public static async Task<HttpResponseMessage> Foo()
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://google.com")
        };

      return   await httpClient.GetAsync("/"); 
        
    }
}
