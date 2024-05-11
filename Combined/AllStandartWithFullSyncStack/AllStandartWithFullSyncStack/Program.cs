using AllStandartWithFullSyncStack.GetResult;
using AllStandartWithFullSyncStack.Result;
using AllStandartWithFullSyncStack.Sync;
using AllStandartWithFullSyncStack.Wait;

namespace AllStandartWithFullSyncStack;

internal class Program
{
    static void Main(string[] args)
    {
        SyncClass syncClass = new();
        string syncResult = syncClass.Foo();

        _ = GetResultClass.Foo();

        ResultClass resultClass = new();
        string resResult = resultClass.Foo();

        WaitClass.Foo();
    }
}
