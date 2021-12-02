using System;
using System.Collections.Generic;

namespace Modular.Abstractions.Contracts;

public interface IContract
{
    Type Type { get; }
    public IEnumerable<string> Required { get; }
}