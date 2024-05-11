namespace VTech.AsyncRefactoring.TestProjects.Result;

internal class Program
{
    static void Main(string[] args)
    {
        _ = Foo().Result;
    }

    public static async Task<string> Foo()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");

        return Guid.NewGuid().ToString();
    }
}
