using MultiProjects.AllStandart.GetResult;
using MultiProjects.AllStandart.Result;
using MultiProjects.AllStandart.Wait;

namespace MultiProjects.AllStandart;

internal class Program
{
    static void Main(string[] args)
    {
        _  = GetResultClass.Foo();

        ResultClass resultClass = new();
        string resResult = resultClass.Foo();

        WaitClass.Foo();
    }
}
