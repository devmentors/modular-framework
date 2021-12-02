using System;
using Modular.Abstractions.Contexts;

namespace Modular.Abstractions.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}