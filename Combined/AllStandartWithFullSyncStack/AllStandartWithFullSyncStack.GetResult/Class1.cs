namespace AllStandartWithFullSyncStack.GetResult;

public class GetResultClass
{
    public static string Foo()
    {
        return Bar().GetAwaiter().GetResult();
    }

    private static async Task<string> Bar()
    { 
        await Task.Yield();

        return Guid.NewGuid().ToString();
    }
}
