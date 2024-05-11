namespace VTech.AsyncRefactoring.TestProjects.Wait;

internal class Program
{
    static void Main(string[] args)
    {
        Foo().Wait();
    }

    public static async Task Foo()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");
    }
}
