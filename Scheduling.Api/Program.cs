using Coravel;
using Coravel.Scheduling.Schedule.Interfaces;
using Scheduling.App;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScheduler().AddSingleton<RepeatableTaskClass>()
    ;
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/schedule", (IScheduler scheduler) =>
{
    scheduler.Schedule<RepeatableTaskClass>()
        .EverySecond()
        .When(async () =>
        {
            return DateTime.Now.Second % 2 == 0;
        });
});
//sd
app.Run();