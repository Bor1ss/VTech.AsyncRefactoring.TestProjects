using ThirdPartyAsyncMethods.SubProj;

namespace ThirdPartyAsyncMethods;

internal class Program
{
    static void Main(string[] args)
    {
        _ = HttpClientBlocking.Foo();
        TaskBlocking.Foo();
        _ = FileReadingBlocking.Foo();
        _ = BlobReadBlocking.Foo();
    }
}
