namespace ThirdPartyAsyncMethods.SubProj;

public class TaskBlocking
{
    public static void Foo()
    {
        //Task.Factory.StartNew(Bar).Wait();
        Console.WriteLine("Bar");
    }

    public static void Bar()
    {
        Console.WriteLine("Bar");
    }
}
