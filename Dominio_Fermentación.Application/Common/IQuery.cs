using FluentResults;
using MediatR;

namespace Dominio_Fermentación.Application.Common
{
    public interface IQuery<T>
        : IRequest<Result<T>>
    {

    }
}
