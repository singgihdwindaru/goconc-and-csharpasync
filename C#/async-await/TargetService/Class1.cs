namespace TargetService;
public static class Class1
{

    public static async Task DoAsync(int iteration)
    {
        await Task.Yield();
        Console.WriteLine($"hello iteration {iteration}");
    }
}
