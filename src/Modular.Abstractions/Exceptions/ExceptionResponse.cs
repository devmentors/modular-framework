using System.Net;

namespace Modular.Abstractions.Exceptions;

public record ExceptionResponse(object Response, HttpStatusCode StatusCode);