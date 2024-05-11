namespace VTech.AsyncRefactoring.TestProjects.OneFile.AllStandart;

internal class Program
{
    static void Main(string[] args)
    {
        FooAsync().GetAwaiter().GetResult();
        FooAsync().Wait();
        _ = GetFooAsync().GetAwaiter().GetResult();
        _ = GetFooAsync().Result;
    }

    public static async Task FooAsync()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");
    }

    public static async Task<string> GetFooAsync()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");

        return Guid.NewGuid().ToString();
    }
}
