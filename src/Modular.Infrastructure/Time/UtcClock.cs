using System;
using Modular.Abstractions.Time;

namespace Modular.Infrastructure.Time
{
    public class UtcClock : IClock
    {
        public DateTime CurrentDate() => DateTime.UtcNow;
    }
}