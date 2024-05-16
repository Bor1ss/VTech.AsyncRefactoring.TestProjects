namespace ThirdPartyAsyncMethods.SubProj;

public class TaskBlocking
{
    public static void Foo()
    {
        Bar();
    }

    public static void Bar()
    {
        Console.WriteLine("Bar");
    }
}
