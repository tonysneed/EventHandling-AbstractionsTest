using System;

namespace AbstractionsTest.Abstractions
{
    public abstract record Event : IEvent
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public DateTime CreationDate { get; init; } = DateTime.UtcNow;
    }
}
