namespace ThirdPartyAsyncMethods.SubProj;

public class TaskBlocking
{
    public static async Task Foo()
    {
        await Task.Factory.StartNew(Bar);
    }

    public static void Bar()
    {
        Console.WriteLine("Bar");
    }
}
