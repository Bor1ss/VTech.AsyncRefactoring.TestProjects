namespace VTech.AsyncRefactoring.TestProjects.GetResult;

internal class Program
{
    static void Main(string[] args)
    {
        Foo().GetAwaiter().GetResult();
    }

    public static async Task Foo()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");
    }
}
