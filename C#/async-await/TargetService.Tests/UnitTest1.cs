using Xunit.Abstractions;

namespace TargetService.Tests;

public class UnitTest1
{ 
    private readonly ITestOutputHelper output;
    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
    }
    [Fact]
    public async void Test1()
    {
        List<Task> tasks = new();
        for (int i = 0; i < 50; i++)
        {
            tasks.Add(Class1.DoAsync(i));
        }
        await Task.WhenAll(tasks);
    }
}