using FluentResults;
using MediatR;

namespace Dominio_Fermentación.Application.Common
{
    public interface ICommand
        : IRequest<Result>
    {

    }

    public interface ICommand<T>
        : IRequest<Result<T>>
    {

    }
}
