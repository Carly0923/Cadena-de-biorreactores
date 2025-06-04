using Dominio_Fermentación.Application.Common;

namespace Dominio_Fermentación.Application.Commands.Units.CreateUnit
{
    public sealed record CreateUnitCommand(
        string Name,
        string Code)
        : ICommand;

}
