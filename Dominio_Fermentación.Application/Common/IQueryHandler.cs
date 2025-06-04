using FluentResults;
using MediatR;

namespace Dominio_Fermentación.Application.Common
{
    public interface IQueryHandler<TRequest, TResponse>
        : IRequestHandler<TRequest, Result<TResponse>>
        where TRequest : IQuery<TResponse>
    {

    }
}
