namespace Bookify.Infrastructure.Outbox;

internal class OutboxOptions
{
    public int InternalInSeconds { get; init; }
    
    public int BatchSize { get; init; }
}