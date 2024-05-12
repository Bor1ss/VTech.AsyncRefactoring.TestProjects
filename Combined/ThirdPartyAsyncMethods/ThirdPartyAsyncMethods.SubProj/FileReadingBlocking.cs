namespace ThirdPartyAsyncMethods.SubProj;
public class FileReadingBlocking
{
    public static string Foo()
    {
        return File.ReadAllTextAsync("").GetAwaiter().GetResult();
    }
}
