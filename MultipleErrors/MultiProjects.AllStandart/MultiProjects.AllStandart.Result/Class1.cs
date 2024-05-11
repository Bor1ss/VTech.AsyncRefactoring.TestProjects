namespace MultiProjects.AllStandart.Result;

public class ResultClass
{
    public string Foo()
    {
        return Bar().Result;
    }

    private async Task<string> Bar()
    {
        await Task.Yield();

        return Guid.NewGuid().ToString();
    }
}
