using System.Collections.Generic;

namespace Modular.Infrastructure.Modules
{
    public record ModuleInfo(string Name, IEnumerable<string> Policies);
}