using System.Threading.Tasks;

namespace Modular.Infrastructure;

public interface IInitializer
{
    Task InitAsync();
}