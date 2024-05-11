using ThirdPartyAsyncMethods.SubProj;

namespace ThirdPartyAsyncMethods;

internal class Program
{
    static void Main(string[] args)
    {
        HttpClientBlocking.Foo();
        TaskBlocking.Foo();
        FileReadingBlocking.Foo();
        BlobReadBlocking.Foo();
    }
}
