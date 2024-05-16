using ThirdPartyAsyncMethods.SubProj;

namespace ThirdPartyAsyncMethods;

internal class Program
{
    static async Task Main(string[] args)
    {
        await HttpClientBlocking.FooAsync();
        await TaskBlocking.FooAsync();
        await FileReadingBlocking.FooAsync();
        await BlobReadBlocking.FooAsync();
    }
}
