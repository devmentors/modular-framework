using System;
using System.Threading.Tasks;

namespace Modular.Infrastructure.Postgres
{
    public interface IUnitOfWork
    {
        Task ExecuteAsync(Func<Task> action);
    }
}