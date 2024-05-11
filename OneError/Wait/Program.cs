namespace VTech.AsyncRefactoring.TestProjects.Wait;

internal class Program
{
    static void Main(string[] args)
    {
    }

    public static async Task FooAsync()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");
    }
}
