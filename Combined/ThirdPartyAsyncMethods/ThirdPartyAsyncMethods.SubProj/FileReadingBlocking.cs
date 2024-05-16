namespace ThirdPartyAsyncMethods.SubProj;
public class FileReadingBlocking
{
    public static async Task<string> Foo()
    {
        return await File.ReadAllTextAsync("");
    }
}
