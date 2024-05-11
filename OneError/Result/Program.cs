namespace VTech.AsyncRefactoring.TestProjects.Result;

internal class Program
{
    static void Main(string[] args)
    {
        _ = GetFooAsync().Result;
    }

    public static async Task<string> GetFooAsync()
    {
        await Task.Yield();
        Console.WriteLine("Hello, World!");

        return Guid.NewGuid().ToString();
    }
}
