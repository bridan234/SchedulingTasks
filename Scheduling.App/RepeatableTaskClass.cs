using Coravel.Invocable;

namespace Scheduling.App;

public class RepeatableTaskClass : IInvocable
{
    public async Task Invoke()
    {
        Console.WriteLine($"{DateTime.Now.ToString("h:mm:ss tt zz")} - This is ascheduled task");
    }
}