namespace ServiceBus.Models;

public record MessageOptions()
{
    public string? Topic { get; init; }
    public DateTimeOffset? ScheduledEnqueueTime { get; init; }
}