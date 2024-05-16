using ThirdPartyAsyncMethods.SubProj;

namespace ThirdPartyAsyncMethods;

internal class Program
{
    static async Task Main(string[] args)
    {
        await HttpClientBlocking.Foo();
        TaskBlocking.Foo();
        await FileReadingBlocking.Foo();
        await BlobReadBlocking.Foo();
    }
}
