using System;
using Modular.Abstractions.Exceptions;

namespace Modular.Infrastructure.Exceptions
{
    public interface IExceptionCompositionRoot
    {
        ExceptionResponse Map(Exception exception);
    }
}