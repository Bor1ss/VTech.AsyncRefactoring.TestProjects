namespace MultiProjects.AllStandart.Wait;

public class WaitClass
{
    public static void Foo()
    {
        Bar().Wait();
    }

    private static async Task Bar()
    {
        await Task.Yield();

        _ = 1;
    }
}
