namespace Implementations;

internal class Program
{
    static void Main(string[] args)
    {
        FooBase fooBase = new();

        string strRes = fooBase.Foo();

        Console.WriteLine(strRes);
    }
}
