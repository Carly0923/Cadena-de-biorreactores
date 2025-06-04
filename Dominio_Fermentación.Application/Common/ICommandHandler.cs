using FluentResults;
using MediatR;

namespace Dominio_Fermentación.Application.Common
{
    public interface ICommandHandler<T>
        : IRequestHandler<T, Result>
        where T : ICommand
    {
    }

    public interface ICommandHandler<TRequest, TResponse>
        : IRequestHandler<TRequest, Result<TResponse>>
        where TRequest : ICommand<TResponse>
    {
    }

}
