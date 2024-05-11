namespace AllStandartWithFullSyncStack.Sync;

public class SyncClass
{
    public string Foo()
    {
        return Bar().Result;
    }

    private ResultWrapper Bar()
    {
        return new ResultWrapper()
        {
            Result = "MyResult"
        };
    }
}
