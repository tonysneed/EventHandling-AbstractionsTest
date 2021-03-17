using System;

namespace AbstractionsTest.Abstractions
{
    public interface IEvent
    {
        Guid Id { get; }
        DateTime CreationDate { get; }
    }
}
