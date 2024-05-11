namespace ThirdPartyAsyncMethods.SubProj;

public class TaskBlocking
{
    public static void Foo()
    {
        Task.Factory.StartNew(Bar).Wait();
    }

    public static void Bar()
    {
        Console.WriteLine("Bar");
    }
}
