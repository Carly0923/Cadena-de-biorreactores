using Dominio_Fermentación.Application.Common;
using Dominio_Fermentación.Contracts.Repositories.Managers;
using Dominio_Fermentación.Entities;
using FluentResults;

namespace EquipmentMonitoring.Application.Queries
{
    public class GetAllUnitsQueryHandler
        : IQueryHandler<GetAllUnitsQuery, IEnumerable<Unit>>
    {

        private IAppRepositoryManager _repositoryManager;

        public GetAllUnitsQueryHandler(
            IAppRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Result<IEnumerable<Unit>>> Handle(GetAllUnitsQuery request, CancellationToken cancellationToken)
        {
            return Result.Ok( await _repositoryManager.Unit.GetUnitsAsync());
        }
    }
}
