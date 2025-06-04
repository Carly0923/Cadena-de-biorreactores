using Dominio_Fermentación.Application.Common;

namespace Dominio_Fermentación.Application.Queries
{
    public sealed record GetAllUnitsQuery()
        : IQuery<IEnumerable<Dominio_Fermentación.Entities.Fermentador>>;
}
