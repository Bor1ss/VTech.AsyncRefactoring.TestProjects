namespace ThirdPartyAsyncMethods.SubProj;
public class FileReadingBlocking
{
    public static async Task<string> FooAsync()
    {
        return await File.ReadAllTextAsync("");
    }
}
