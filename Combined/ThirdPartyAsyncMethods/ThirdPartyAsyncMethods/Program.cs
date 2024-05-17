using ThirdPartyAsyncMethods.SubProj;

namespace ThirdPartyAsyncMethods;

internal class Program
{
    static async Task Main(string[] args)
    {
        await HttpClientBlocking.FooAsync();
        TaskBlocking.Foo();
        await FileReadingBlocking.FooAsync();
        BlobReadBlocking.Foo();
    }
}
