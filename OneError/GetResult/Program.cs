namespace VTech.AsyncRefactoring.TestProjects.GetResult;

internal class Program
{
    static void Main(string[] args)
    {
        FooAsync().GetAwaiter().GetResult();
    }

    public static async Task FooAsync()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");
    }
}
