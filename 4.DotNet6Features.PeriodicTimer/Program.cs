
using var timer = new PeriodicTimer(TimeSpan.FromSeconds(3));

Task.Run(async () =>
{
    while (await timer.WaitForNextTickAsync())
    {
        Console.WriteLine($"Timer EVENT @ {DateTime.Now:HH:mm:ss}");
    }
});

Thread.Sleep(6000);
timer.Dispose();







